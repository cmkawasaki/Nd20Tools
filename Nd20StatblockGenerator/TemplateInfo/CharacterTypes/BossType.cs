using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    public class BossType : ICharacterType
    {
        public BossType()
        {

        }

        public override string GetTitleText()
        {
            return "Boss";
        }

        public override int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower)
        {
            int AveHP = 0;
            int TotalLevel = 0;

            foreach (ClassStatEntry MyEntry in MyList)
            {
                AveHP += (int)(((MyEntry.HDType * 2) + ConMod + BonusHPFromPower) * MyEntry.ClassLevel);
                TotalLevel += MyEntry.ClassLevel;
            }
            AveHP = GetMax(TotalLevel, AveHP);

            return AveHP;
        }

        public override NPCTemplate CreateTemplate(NPCTemplate SourceTemplate)
        {
            //List<int> MyStats = new List<int>();

            //MyStats.Add(SourceTemplate.BaseFortSave);
            //MyStats.Add(SourceTemplate.BaseReflexSave);
            //MyStats.Add(SourceTemplate.BaseWillSave);

            //List<int> Bonuses = new List<int>();

            //Bonuses.Add(0);
            //Bonuses.Add(0);
            //Bonuses.Add(0);

            //int Max = GetMaximumFromList(MyStats);
            //int Min = GetMinimumFromList(MyStats);

            //Bonuses[Max] = 2;
            //Bonuses[Min] = 3;

            NPCTemplate BossTemplate = new NPCTemplate("", 0, 0, 0, 0, 0, "luck", 2, 1, 1, 1, 0, 0, null, 0, 0, 0, "", null);

            return BossTemplate;
        }

        public override string GetXPText()
        {
            return " (worth x2)";
        }

        public override string GetFlavorText()
        {
            string BossString = RTFWriter.ReturnRTFReturn();
            BossString += RTFWriter.FormatWithBold("Immunities:");
            BossString += " A boss creature is immune to up four of the following: ability damage, daze, death, paralysis and stunning effects.";
            BossString += RTFWriter.ReturnRTFReturn();
            BossString += RTFWriter.ReturnRTFReturn();
            BossString += RTFWriter.FormatWithBold("Boss Creature:");
            BossString += " A boss creature gains an additional move action and attack action each turn that can be spent performing any action other than casting a spell, using supernatural or spell-like ability, manifesting a psionic power or performing a technique.";
            BossString += RTFWriter.ReturnRTFReturn();
            BossString += RTFWriter.ReturnRTFReturn();
            BossString += "Twice per encounter, the boss creature may manifest a power, cast a spell, supernatural or spell-" +
                "like ability, or use a technique with its extra action, or make an additional attack at its highest attack bonus and a second at a -5 penalty. The extra attacks stack with other effects that grant " +
                "additional attacks, such as the " + RTFWriter.FormatWithItalics("Renzuki") +
                " taijutsu technique.";
            BossString += RTFWriter.ReturnRTFReturn();

            return BossString;
        }
    }
}
