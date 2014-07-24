using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace TacmapGenerator
{
    [DataContract]
    public class TacmapData
    {
        public char[,] currentData;
        public char[,] previousData;
        [DataMember(Order=0)]
        public int Width;
        [DataMember(Order = 1)]
        public int Height;

        [DataMember(Name="CurrentData", Order=2)]
        public char[] CurrentData
        {
            get
            {
                char[] temp = new char[currentData.GetLength(0) * currentData.GetLength(1)];
                Buffer.BlockCopy(currentData, 0, temp, 0, temp.Length * sizeof(char));
                return temp;
            }
            set
            {
                char[,] temp = new char[this.Width,this.Height];
                Buffer.BlockCopy(value, 0, temp, 0, value.Length * sizeof(char));
                this.currentData = temp;
            }
        }

        [DataMember(Name = "PreviousData", Order=3)]
        public char[] PreviousData
        {
            get
            {
                char[] temp = new char[previousData.GetLength(0) * previousData.GetLength(1)];
                Buffer.BlockCopy(previousData, 0, temp, 0, temp.Length * sizeof(char));
                return temp;
            }
            set
            {
                char[,] temp = new char[this.Width, this.Height];
                Buffer.BlockCopy(value, 0, temp, 0, value.Length * sizeof(char));
                this.previousData = temp;
            }
        }

        public char[,] Map
        {
            get
            {
                return currentData;
            }
        }

        public TacmapData()
            : this(10, 10)
        { }

        public TacmapData(int width, int height)
        {
            currentData = new char[width, height];
            previousData = new char[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    currentData[i, j] = '.';
                    previousData[i, j] = '.';
                }
            }

            Width = width;
            Height = height;
        }

        public void SaveSquare(int i, int j, char data)
        {
            previousData[i, j] = currentData[i, j];
            currentData[i, j] = data;
        }

        public void DrawLine(int firstWidth, int firstHeight, int secondWidth, int secondHeight, char TacmapLetter)
        {
            SavePreviousState();

            if (firstWidth == secondWidth)
            {
                for (int i = Math.Min(firstHeight, secondHeight); i <= Math.Max(firstHeight, secondHeight); i++)
                {
                    currentData[firstWidth, i] = TacmapLetter;
                }
            }
            else if (firstHeight == secondHeight)
            {
                for (int i = Math.Min(firstWidth, secondWidth); i <= Math.Max(firstWidth, secondWidth); i++)
                {
                    currentData[i, firstHeight] = TacmapLetter;
                }
            }
        }

        public void MoveTacmapObject(int firstWidth, int firstHeight, int secondWidth, int secondHeight, char TacmapLetter, bool isRecursive)
        {
            SavePreviousState();

            char[,] tempTacmap = new char[Width, Height];
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    tempTacmap[i, j] = currentData[i, j];
                }
            }
            MoveCharacterRecursive(ref tempTacmap, currentData[firstWidth, firstHeight], firstWidth, firstHeight, secondWidth, secondHeight, TacmapLetter, isRecursive);

        }

        private void SavePreviousState()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    previousData[i, j] = currentData[i, j];
                }
            }
        }

        private void MoveCharacterRecursive(ref char[,] tempTacmap, char character, int firstWidth, int firstHeight, int secondWidth, int secondHeight, char TacmapLetter, bool isRecursive)
        {
            if (IsBetween(firstWidth, 0, Width) && IsBetween(secondWidth, 0, Width) &&
                IsBetween(firstHeight, 0, Height) && IsBetween(firstHeight, 0, Height) &&
                tempTacmap[firstWidth, firstHeight] == character)
            {
                currentData[secondWidth, secondHeight] = currentData[firstWidth, firstHeight];
                currentData[firstWidth, firstHeight] = TacmapLetter;
                tempTacmap[firstWidth, firstHeight] = '.';

                //Recursive
                if (isRecursive)
                {
                    MoveCharacterRecursive(ref tempTacmap, character, firstWidth - 1, firstHeight, secondWidth - 1, secondHeight, TacmapLetter, isRecursive);
                    MoveCharacterRecursive(ref tempTacmap, character, firstWidth + 1, firstHeight, secondWidth + 1, secondHeight, TacmapLetter, isRecursive);
                    MoveCharacterRecursive(ref tempTacmap, character, firstWidth, firstHeight - 1, secondWidth, secondHeight - 1, TacmapLetter, isRecursive);
                    MoveCharacterRecursive(ref tempTacmap, character, firstWidth, firstHeight + 1, secondWidth, secondHeight + 1, TacmapLetter, isRecursive);
                }
            }
            else if (IsBetween(firstWidth, 0, Width) && IsBetween(firstHeight, 0, Height) && tempTacmap[firstWidth, firstHeight] == character)
            {
                currentData[firstWidth, firstHeight] = TacmapLetter;
                tempTacmap[firstWidth, firstHeight] = '.';
            }
        }

        private static bool IsBetween(int item, int floor, int ceiling)
        {
            if (item >= ceiling)
                return false;
            else if (item < floor)
                return false;
            else
                return true;
        }
    }
}
