using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    class YukiBunshinType : ICharacterType
    {
        public YukiBunshinType()
        {

        }

        public override string GetTitleText()
        {
            return "Yuki Bunshin";
        }

        public override int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower)
        {
            int AveHP = 0;

            AveHP = (int)(ClassStatEntry.GetTotalLevel(MyList) / 2);

            return AveHP;
        }

        public override NPCTemplate CreateTemplate(NPCTemplate SourceTemplate)
        {
            NPCTemplate YukiBunshinTemplate = new NPCTemplate("", -SourceTemplate.TemplateCR, 0, 0, 0, -4, "bunshin", -5, -2, -2, -2, 0, -SourceTemplate.MaxChakraPool, null, 0, 0, 0, "", null);
            YukiBunshinTemplate.TemplateAttacks.MAX_ATTACK_COUNT = 2;
            return YukiBunshinTemplate;
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
