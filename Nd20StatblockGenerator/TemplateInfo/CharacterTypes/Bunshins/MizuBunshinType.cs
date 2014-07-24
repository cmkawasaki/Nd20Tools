using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    class MizuBunshinType : ICharacterType
    {
        public MizuBunshinType()
        {

        }

        public override string GetTitleText()
        {
            return "Mizu Bunshin";
        }

        public override int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower)
        {
            int AveHP = 0;

            AveHP = (int)(ClassStatEntry.GetTotalLevel(MyList));

            return AveHP;
        }

        public override NPCTemplate CreateTemplate(NPCTemplate SourceTemplate)
        {
            NPCTemplate MizuBunshinTemplate = new NPCTemplate("", -SourceTemplate.TemplateCR, 0, 0, 0, -4, "bunshin", -5, -4, -4, -4, 0, -SourceTemplate.MaxChakraPool, null, 0, 0, 0, "water resistance 10", null);
            MizuBunshinTemplate.TemplateAttacks.MAX_ATTACK_COUNT = 2;
            return MizuBunshinTemplate;
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
