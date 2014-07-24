using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    public class EndBossType : ICharacterType
    {
        public EndBossType()
        {

        }

        public override string GetTitleText()
        {
            return "End Boss";
        }

        public override int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower)
        {
            int AveHP = 0;
            int TotalLevel = 0;

            foreach (ClassStatEntry MyEntry in MyList)
            {
                AveHP += (int)(((MyEntry.HDType * 16) + ConMod + BonusHPFromPower) * MyEntry.ClassLevel);
                TotalLevel += MyEntry.ClassLevel;
            }
            AveHP = GetMax(TotalLevel, AveHP);

            return AveHP;
        }

        public override NPCTemplate CreateTemplate(NPCTemplate SourceTemplate)
        {
            NPCTemplate BossTemplate = new NPCTemplate("", 0, 0, 0, 0, 0, "luck", 3, 2, 2, 2, 0, 0, null, 0, 0, 0, "", null);

            return BossTemplate;
        }

        public override string GetXPText()
        {
            return " (worth x10)";
        }

        public override string GetFlavorText()
        {
            string SoloString = RTFWriter.ReturnRTFReturn();
            SoloString += RTFWriter.FormatWithBold("Immunities:");
            SoloString += " The end boss creature is immune to ability damage, ability drain, daze, death effects, fear, nausea, negative levels, paralysis, and stunning effects, as well as other effects that cause the loss of a turn.";
            SoloString += RTFWriter.ReturnRTFReturn();
            SoloString += RTFWriter.ReturnRTFReturn();
            SoloString += RTFWriter.FormatWithBold("End Boss Creature:");
            SoloString += " The end boss creature gains an additional move action and attack action each turn that can be spent performing any action other " +
                "than casting a spell, using supernatural or spelllike ability, manifesting a psionic power or performing a technique.";
            SoloString += RTFWriter.ReturnRTFReturn();
            SoloString += RTFWriter.ReturnRTFReturn();
            SoloString += "Three times per encounter, the end boss creature may manifest a power, cast a spell, supernatural or spell-like ability, or use " +
                "a technique with its extra action, or make an additional attack at its highest attack bonus, a second at a -5 penalty and a third at a -10 penalty. The extra " +
                "attacks stack with other effects that grant additional attacks, such as the " + RTFWriter.FormatWithItalics("Renzuki") + 
                " taijutsu technique.";
            SoloString += RTFWriter.ReturnRTFReturn();

            return SoloString;
        }
    }
}
