using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    public class SoloType : ICharacterType
    {
        public SoloType()
        {

        }

        public override string GetTitleText()
        {
            return "Solo";
        }

        public override int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower)
        {
            int AveHP = 0;
            int TotalLevel = 0;

            foreach (ClassStatEntry MyEntry in MyList)
            {
                AveHP += (int)(((MyEntry.HDType * 4) + ConMod + BonusHPFromPower) * MyEntry.ClassLevel);
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
            return " (worth x3)";
        }

        public override string GetFlavorText()
        {
            string SoloString = RTFWriter.ReturnRTFReturn();
            SoloString += RTFWriter.FormatWithBold("Immunities:");
            SoloString += " A solo creature is immune to death effects and effects that cause the loss of a turn, as well as up to five of the following: ability damage, ability drain, daze, fear, nausea, negative levels, paralysis, and stunning effects.";
            SoloString += RTFWriter.ReturnRTFReturn();
            SoloString += RTFWriter.ReturnRTFReturn();
            SoloString += RTFWriter.FormatWithBold("Solo Creature:");
            SoloString += " The solo creature either gains extra actions or multiple turns, as shown below.";
            SoloString += RTFWriter.ReturnRTFReturn();
            SoloString += RTFWriter.FormatWithItalics("Extra Actions:");
            SoloString += "A solo creature gains an additional move action and attack action each turn that can be spent performing any action other than casting a spell, using supernatural or spell-like ability, manifesting a psionic power or performing a technique.";
            SoloString += RTFWriter.ReturnRTFReturn();
            SoloString += "Three times per encounter, the solo creature may manifest a power, cast a spell, supernatural or spell-like ability, or use a technique with its extra action, or make an additional attack at its highest attack bonus and a second at a -5 penalty. The extra attacks stack with other effects that grant additional attacks, such as the " +
                RTFWriter.FormatWithItalics("Renzuki") +
                " taijutsu technique.";
            SoloString += RTFWriter.ReturnRTFReturn();
            SoloString += RTFWriter.FormatWithItalics("Multiple Turns:");
            SoloString += "The solo creature rolls initiative twice (or more); pick the highest roll and divide it in half. The solo creature will act on both of those initiative counts each round.";
            SoloString += RTFWriter.ReturnRTFReturn();
            SoloString += "In the case of abilities that take effect or end at the start of the solo creature's turn, use the following rule as guidance: if the ability ends or takes effect at the start of the creature's turn, use the creature's first turn that round; if it ends or takes effect at the end of the creature's turn, use the end of the creature's second turn that round.";
            SoloString += RTFWriter.ReturnRTFReturn();
            SoloString += "An ability that takes effect at the beginning or end of the creature's turn only takes effect once each round.";
            SoloString += RTFWriter.ReturnRTFReturn();
            SoloString += "This is especially useful if the solo creature has multiple modes of attack, as it can avoid repeating its action and use different sets of abilities on each of its turns.";
            SoloString += RTFWriter.ReturnRTFReturn();

            return SoloString;
        }
    }
}
