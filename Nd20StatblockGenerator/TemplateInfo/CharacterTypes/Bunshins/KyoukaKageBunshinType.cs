using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    class KyoukaKageBunshinType : ICharacterType
    {
        public KyoukaKageBunshinType()
        {

        }

        public override string GetTitleText()
        {
            return "Kyouka Kage Bunshin";
        }

        public override int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower)
        {
            int AveHP = 0;

            AveHP = (int)(((ClassStatEntry.GetTotalLevel(MyList) / 3) * 2) + Math.Min(ClassStatEntry.GetTotalLevel(MyList), 15));

            return AveHP;
        }

        public override NPCTemplate CreateTemplate(NPCTemplate SourceTemplate)
        {
            NPCTemplate KageBunshinTemplate = new NPCTemplate("", -SourceTemplate.TemplateCR, 0, 0, 0, -3, "bunshin", -4, -2, -2, -2, 0, -((int)((SourceTemplate.MaxChakraPool *2)/3)), null, 0, 0, 0, "", null);
            KageBunshinTemplate.TemplateAttacks.MAX_ATTACK_COUNT = 2;
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
