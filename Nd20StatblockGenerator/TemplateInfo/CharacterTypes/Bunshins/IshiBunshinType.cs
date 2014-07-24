using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    class IshiBunshinType : ICharacterType
    {
        public IshiBunshinType()
        {

        }

        public override string GetTitleText()
        {
            return "Ishi Bunshin";
        }

        public override int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower)
        {
            int AveHP = 0;

            AveHP = (int)(ClassStatEntry.GetTotalLevel(MyList));

            return AveHP;
        }

        public override NPCTemplate CreateTemplate(NPCTemplate SourceTemplate)
        {
            NPCTemplate ishiBunshinTemplate = new NPCTemplate("", -SourceTemplate.TemplateCR, 0, 0, 0, 0, "bunshin", 0, 0, 0, 0, 0, (10-SourceTemplate.MaxChakraPool), null, 0, 0, 0, "earth resistance 15, hardness 4", null);
            ishiBunshinTemplate.TemplateAttacks.MAX_ATTACK_COUNT = 3;
            return ishiBunshinTemplate;
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
