using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    public abstract class ICharacterType
    {
        public ICharacterType()
        {

        }

        public abstract string GetTitleText();
        public abstract int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower);
        public abstract NPCTemplate CreateTemplate(NPCTemplate SourceTemplate);
        public abstract string GetXPText();
        public abstract string GetFlavorText();

        #region Protected Helper Functions

        protected static int GetMax(int A, int B)
        {
            if (A > B)
                return A;
            else
                return B;
        }

        protected static int GetMinimumFromList(List<int> Numbers)
        {
            int MIN = 50;
            int MIN_Spot = -1;

            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Numbers[i] < MIN)
                {
                    MIN = Numbers[i];
                    MIN_Spot = i;
                }
            }

            return MIN_Spot;
        }

        protected static int GetMaximumFromList(List<int> Numbers)
        {
            int MAX = -10;
            int MAX_Spot = -1;

            for (int i = Numbers.Count - 1; i > -1; i--)
            {
                if (Numbers[i] > MAX)
                {
                    MAX = Numbers[i];
                    MAX_Spot = i;
                }
            }

            return MAX_Spot;
        }

        #endregion
    }
}
