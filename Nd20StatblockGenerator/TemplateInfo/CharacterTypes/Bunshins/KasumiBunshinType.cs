using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    class KasumiBunshinType : ICharacterType
    {
        public KasumiBunshinType()
        {

        }

        public override string GetTitleText()
        {
            return "Kasumi Bunshin";
        }

        public override int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower)
        {
            int AveHP = 0;

            AveHP = (int)(ClassStatEntry.GetTotalLevel(MyList) / 4);

            return AveHP;
        }

        public override NPCTemplate CreateTemplate(NPCTemplate SourceTemplate)
        {
            NPCTemplate KageBunshinTemplate = new NPCTemplate("", -SourceTemplate.TemplateCR, 0, 0, 0, -5, "bunshin", 0, -2, -2, -2, 0, -SourceTemplate.MaxChakraPool, null, 0, 0, 0, "20% chance to ignore physical attacks, wind resistance 5, fire instant death", null);
            KageBunshinTemplate.TemplateAttacks.MAX_ATTACK_COUNT = 3;
            return KageBunshinTemplate;
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
