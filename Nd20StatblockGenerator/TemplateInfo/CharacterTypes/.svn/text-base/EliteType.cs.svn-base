using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    public class EliteType : ICharacterType
    {
        public EliteType()
        {

        }

        public override string GetTitleText()
        {
            return "Elite";
        }

        public override int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower)
        {
            int AveHP = 0;
            int TotalLevel = 0;

            foreach (ClassStatEntry MyEntry in MyList)
            {
                AveHP += (int)(((MyEntry.HDType) + ConMod + BonusHPFromPower) * MyEntry.ClassLevel);
                TotalLevel += MyEntry.ClassLevel;
            }
            AveHP = GetMax(TotalLevel, AveHP);

            return AveHP;
        }

        public override NPCTemplate CreateTemplate(NPCTemplate SourceTemplate)
        {
            List<int> MyStats = new List<int>();

            //MyStats.Add(SourceTemplate.BaseFortSave);
            //MyStats.Add(SourceTemplate.BaseReflexSave);
            //MyStats.Add(SourceTemplate.BaseWillSave);

            //List<int> Bonuses = new List<int>();

            //Bonuses.Add(0);
            //Bonuses.Add(0);
            //Bonuses.Add(0);

            //int Max = GetMaximumFromList(MyStats);
            //int Min = GetMinimumFromList(MyStats);

            //Bonuses[Max] = 1;
            //Bonuses[Min] = 2;

            NPCTemplate EliteTemplate = new NPCTemplate("", 0, 0, 0, 0, 0, "luck", 1, 0, 0, 0, 0, 0, null, 0, 0, 0, "", null);

            return EliteTemplate;
        }

        public override string GetXPText()
        {
            return " (worth x2)";
        }

        public override string GetFlavorText()
        {
            string EliteString = RTFWriter.ReturnRTFReturn();
            EliteString += RTFWriter.FormatWithBold("Elite Creature:");
            EliteString += " An elite creature gains an additional attack or move action each turn that cannot be spent performing a technique, casting a spell or manifesting a power.";
            EliteString += RTFWriter.ReturnRTFReturn();

            return EliteString;
        }
    }
}
