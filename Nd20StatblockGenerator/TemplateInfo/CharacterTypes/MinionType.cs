using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    public class MinionType : ICharacterType
    {
        public MinionType()
        {

        }

        public override string GetTitleText()
        {
            return "Minion";
        }

        public override int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower)
        {
            int AveHP = 0;

            AveHP = ClassStatEntry.GetTotalLevel(MyList) + ConMod;

            return AveHP;
        }

        public override NPCTemplate CreateTemplate(NPCTemplate SourceTemplate)
        {
            //Send an Empty Template
            return new NPCTemplate("", 0, 0, 0, 0, 0, "class", 0, 0, 0, 0, 0, 0, null, 0, 0, 0, "", null);
        }

        public override string GetXPText()
        {
            return " (worth 1/4)";
        }

        public override string GetFlavorText()
        {
            string MinionString = RTFWriter.ReturnRTFReturn();
            MinionString += RTFWriter.FormatWithBold("Minion Creature:");
            MinionString += " A minion creature only deals half damage from attacks and techniques. Damage dealt by tools are unaffected.";
            MinionString += RTFWriter.ReturnRTFReturn();

            return MinionString;
        }
    }
}
