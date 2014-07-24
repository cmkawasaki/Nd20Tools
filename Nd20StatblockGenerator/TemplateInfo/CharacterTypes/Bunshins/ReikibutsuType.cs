using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    class ReikibutsuType : ICharacterType
    {
        public ReikibutsuType()
        {

        }

        public override string GetTitleText()
        {
            return "Reikibutsu";
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

            int returnValue = (AveHP / 2);

            return returnValue;
        }

        public override NPCTemplate CreateTemplate(NPCTemplate SourceTemplate)
        {
            CharacterStats stats = new CharacterStats(0, 0, 0, Math.Min((14 - SourceTemplate.BaseStats.IntScore), 0), Math.Min((14 - SourceTemplate.BaseStats.WisScore), 0), Math.Min((14 - SourceTemplate.BaseStats.ChaScore), 0));

            NPCTemplate reikibutsuTemplate = new NPCTemplate("", -5, 0, 0, 0, -5, "reikibutsu", -5, -5, -5, -5, 0, -(SourceTemplate.MaxChakraPool / 2), stats, 0, 0, 0, "", null);
            return reikibutsuTemplate;
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
