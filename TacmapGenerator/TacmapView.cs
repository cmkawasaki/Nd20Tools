using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TacmapGenerator
{
    public partial class TacmapView : UserControl
    {
        public int PixelPerTile = 25;
        public TacmapData TacmapData;
        Point? firstLineData = null;
        Point? firstMouseClickData = null;

        public int WidthTiles
        {
            get;
            set;
        }
        public int HeightTiles
        {
            get;
            set;
        }
        public char TacmapLetter
        {
            get;
            set;
        }

        public bool DraggingMovementSwitch
        {
            get;
            set;
        }

        public bool GroupMovementSwitch
        {
            get;
            set;
        }

        public StencilType CurrentStencil
        {
            get
            {
                return _CurrentStencil;
            }
            set
            {
                firstLineData = null;
                _CurrentStencil = value;
            }
        }

        private StencilType _CurrentStencil;

        public TacmapView()
            : this(10, 10)
        {

        }

        public TacmapView(int widthTiles, int heightTiles)
        {
            InitializeComponent();
            WidthTiles = widthTiles;
            HeightTiles = heightTiles;

            this.Width = PixelPerTile * WidthTiles;
            this.Height = PixelPerTile * HeightTiles;

            TacmapData = new TacmapData(widthTiles, heightTiles);
        }

        public void ResizeControl(int widthTiles, int heightTiles)
        {
            this.WidthTiles = widthTiles;
            this.HeightTiles = heightTiles;

            TacmapData = new TacmapData(widthTiles, heightTiles);

            this.Width = PixelPerTile * WidthTiles;
            this.Height = PixelPerTile * HeightTiles;

            this.InvokePaint(this, new PaintEventArgs(this.CreateGraphics(), this.DisplayRectangle));
        }

        private void TacmapView_Load(object sender, EventArgs e)
        {

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (true == DraggingMovementSwitch)
            {
                firstMouseClickData = e.Location;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (null != firstMouseClickData && true == DraggingMovementSwitch)
            {
                int firstWidth = (int)(firstMouseClickData.Value.X / PixelPerTile);
                int firstHeight = (int)(firstMouseClickData.Value.Y / PixelPerTile);

                int secondWidth = (int)(e.X / PixelPerTile);
                int secondHeight = (int)(e.Y / PixelPerTile);

                if (firstWidth != secondWidth || firstHeight != secondHeight)
                {
                    if (IsBetween(firstWidth, 0, WidthTiles) && IsBetween(firstHeight, 0, HeightTiles) && TacmapData.Map[firstWidth, firstHeight] != '.')
                    {
                        TacmapData.MoveTacmapObject(firstWidth, firstHeight, secondWidth, secondHeight, TacmapLetter, this.GroupMovementSwitch);
                        firstMouseClickData = null;
                        this.OnPaint(new PaintEventArgs(this.CreateGraphics(), this.Bounds));
                    }
                }
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

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            MouseEventArgs eventArgs = (MouseEventArgs)e;

            int width = (int)(eventArgs.X / PixelPerTile);
            int height = (int)(eventArgs.Y / PixelPerTile);

            switch (CurrentStencil)
            {
                case StencilType.SINGLE_POINT:
                    TacmapData.SaveSquare(width, height, TacmapLetter);
                    break;
                case StencilType.LINE:
                    if (firstLineData == null)
                    {
                        firstLineData = new Point(width, height);
                    }
                    else
                    {
                        TacmapData.DrawLine(firstLineData.Value.X, firstLineData.Value.Y, width, height, TacmapLetter);
                        firstLineData = new Point(width, height);
                    }
                    break;
                default:
                    break;
            }


            this.OnPaint(new PaintEventArgs(this.CreateGraphics(), this.Bounds));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);

            //Draw Vertical Lines
            for (int i = 25; i < this.Width; i += 25)
            {
                graphics.DrawLine(new Pen(Color.Red), new Point(i - 2, 0), new Point(i - 2, this.Height));
            }

            //Draw Horizontal Lines
            for (int i = 25; i < this.Height; i += 25)
            {
                graphics.DrawLine(new Pen(Color.Red), new Point(0, i - 2), new Point(this.Width, i - 2));
            }

            //Draw Characters
            for (int i = 0; i < this.WidthTiles; i++)
            {
                for (int j = 0; j < this.HeightTiles; j++)
                {
                    string stringToDraw = TacmapData.Map[i, j].ToString();
                    Brush brush = Brushes.Black;
                    graphics.DrawString(stringToDraw, new System.Drawing.Font(FontFamily.GenericMonospace, 12f), Brushes.Black, new PointF(i * PixelPerTile + 3, j * PixelPerTile + 3));
                }
            }

            //graphics.DrawLine(new Pen(Color.Red), new Point(25, 0), new Point(25, this.Height));
            graphics.Save();
            graphics.Dispose();
        }

        public void PaintMe(PaintEventArgs e)
        {
            OnPaint(e);
        }

        public void Print(string fileName, string initText)
        {

            StringBuilder builder = PrintTacmapToString(initText);

            TextWriter writer = new StreamWriter(fileName);

            writer.Write(builder.ToString());

            writer.Close();
            writer.Dispose();
        }

        public void CopyToClipboard(string initText)
        {
            StringBuilder builder = PrintTacmapToString(initText);
            Clipboard.SetText(builder.ToString());
        }

        private StringBuilder PrintTacmapToString(string initText)
        {
            StringBuilder builder = new StringBuilder();

            int numberSizePerVertical = 2;

            //Print spaces to map to the first line
            for (int i = 0; i < numberSizePerVertical + 1; i++)
            {
                builder.Append(' ');
            }
            for (int i = 0; i < WidthTiles; i++)
            {
                builder.Append(Number2String(i, true));
                builder.Append(' ');
            }

            builder.AppendLine("");

            //Print each horizontal line
            for (int i = 0; i < HeightTiles; i++)
            {
                //Print the initial number, plus a space
                builder.Append(i.ToString("D" + numberSizePerVertical.ToString()));
                builder.Append(" ");

                for (int j = 0; j < this.WidthTiles; j++)
                {
                    builder.Append(TacmapData.Map[j, i]);
                    builder.Append(' ');
                }
                builder.AppendLine("");
            }

            //Print spaces to map to the first line
            for (int i = 0; i < numberSizePerVertical + 1; i++)
            {
                builder.Append(' ');
            }
            for (int i = 0; i < WidthTiles; i++)
            {
                builder.Append(Number2String(i, true));
                builder.Append(' ');
            }

            //Print Initiative line;
            builder.AppendLine();
            builder.Append(initText);

            return builder;
        }

        private String Number2String(int number, bool isCaps)
        {
            Char c = (Char)((isCaps ? 65 : 97) + (number));

            return c.ToString();
        }
    }

    public enum StencilType
    {
        SINGLE_POINT,
        LINE
    };
}
