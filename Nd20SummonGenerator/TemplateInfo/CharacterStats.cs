using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    [Serializable]
    public class CharacterStats
    {
        #region Public Properties
        public int StrScore
        {
            get
            {
                return _strScore;
            }
            set
            {
                _strScore = value;
                _strMod = CalculateStatMod(value);
            }
        }

        public int DexScore
        {
            get
            {
                return _dexScore;
            }
            set
            {
                _dexScore = value;
                _dexMod = CalculateStatMod(value);
            }
        }

        public int ConScore
        {
            get
            {
                return _conScore;
            }
            set
            {
                _conScore = value;
                _conMod = CalculateStatMod(value);
            }
        }

        public int IntScore
        {
            get
            {
                return _intScore;
            }
            set
            {
                _intScore = value;
                _intMod = CalculateStatMod(value);
            }
        }

        public int WisScore
        {
            get
            {
                return _wisScore;
            }
            set
            {
                _wisScore = value;
                _wisMod = CalculateStatMod(value);
            }
        }

        public int ChaScore
        {
            get
            {
                return _chaScore;
            }
            set
            {
                _chaScore = value;
                _chaMod = CalculateStatMod(value);
            }
        }

        public int StrMod
        {
            get
            {
                return _strMod;
            }
        }

        public int DexMod
        {
            get
            {
                return _dexMod;
            }
        }

        public int ConMod
        {
            get
            {
                return _conMod;
            }
        }

        public int IntMod
        {
            get
            {
                return _intMod;
            }
        }

        public int WisMod
        {
            get
            {
                return _wisMod;
            }
        }

        public int ChaMod
        {
            get
            {
                return _chaMod;
            }
        }
        #endregion

        public CharacterStats()
        {
            //Blank on purpose
        }

        public CharacterStats(int Str, int Dex, int Con, int Int, int Wis, int Cha)
        {
            StrScore = Str;
            DexScore = Dex;
            ConScore = Con;
            IntScore = Int;
            WisScore = Wis;
            ChaScore = Cha;
        }

        #region Private Variables
        private int _strScore;
        private int _dexScore;
        private int _conScore;
        private int _intScore;
        private int _wisScore;
        private int _chaScore;
        private int _strMod;
        private int _dexMod;
        private int _conMod;
        private int _intMod;
        private int _wisMod;
        private int _chaMod;

        private static int CalculateStatMod(int Stat)
        {
            if (Stat >= 10)
            {
                return (((Stat - 10) / 2));
            }
            else
            {
                return (((Stat - 11) / 2));
            }
        }
        #endregion
    }
}
