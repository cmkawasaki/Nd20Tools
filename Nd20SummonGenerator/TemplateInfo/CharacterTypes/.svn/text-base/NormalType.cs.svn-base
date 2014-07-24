using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    public class NormalType : ICharacterType
    {
        public NormalType()
        {

        }

        public override string GetTitleText()
        {
            return "";
        }

        public override int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower)
        {
            int AveHP = 0;
            int TotalLevel = 0;

            foreach (ClassStatEntry MyEntry in MyList)
            {
                AveHP += (int)(((MyEntry.HDType / 2) + ConMod + BonusHPFromPower + .5) * MyEntry.ClassLevel);
                TotalLevel += MyEntry.ClassLevel;
            }
            AveHP = GetMax(TotalLevel, AveHP);

            return AveHP;
        }

        public override NPCTemplate CreateTemplate(NPCTemplate SourceTemplate)
        {
            //Send a null template
            return new NPCTemplate("", 0, 0, 0, 0, 0, "class", 0, 0, 0, 0, 0, 0, null, 0, 0, 0, "", null);
        }

        public override string GetXPText()
        {
            return "";
        }

        public override string GetFlavorText()
        {
            return "";
        }
    }
}
