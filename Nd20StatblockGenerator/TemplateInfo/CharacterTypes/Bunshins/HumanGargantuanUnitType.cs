using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    class HumanGargantuanUnitType : ICharacterType
    {
        public HumanGargantuanUnitType()
        {

        }

        public override string GetTitleText()
        {
            return "Human Gargantuan Unit";
        }

        public override int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower)
        {
            int AveHP = 0;

            AveHP = (int)(ClassStatEntry.GetTotalLevel(MyList));

            return AveHP;
        }

        public override NPCTemplate CreateTemplate(NPCTemplate SourceTemplate)
        {
            XMLCharacterClass humanoidClass = new XMLCharacterClass();
            humanoidClass.ClassBABRate = XMLCharacterClass.BABType.THREE_QUARTERS;
            humanoidClass.ClassBonusChakra = XMLCharacterClass.BonusChakraType.NONE;
            humanoidClass.ClassBonusReserve = XMLCharacterClass.BonusReserveType.NONE;
            humanoidClass.ClassDefense = XMLCharacterClass.ClassDefType.NONE;
            humanoidClass.ClassReputation = XMLCharacterClass.RepType.NONE;
            humanoidClass.ClassTitle = "Humanoid Unit";
            humanoidClass.FortSaveRate = XMLCharacterClass.SaveType.POOR;
            humanoidClass.ReflexSaveRate = XMLCharacterClass.SaveType.PRCPROGRESSION;
            humanoidClass.WillSaveRate = XMLCharacterClass.SaveType.POOR;
            humanoidClass.HDType = 8;
            humanoidClass.MaxLevel = 10;
            humanoidClass.TalentList = new List<string>();
            humanoidClass.SkillPointsPerLevel = 0;

            for (int i = 0; i < humanoidClass.MaxLevel; i++)
            {
                humanoidClass.TalentList.Add("");
            }

            NPCTemplate templateToMerge = humanoidClass.CreateClassTemplate(10, 1, 10, SourceTemplate.BaseStats, 0);

            NPCTemplate humanGargantuanUnitTemplate = new NPCTemplate(SourceTemplate.CharacterName + " Unit", 4, 4, 0, 0, 0, "", 0, 0, 0, 0, 0, 0, null, 0, 0, -5, "10 attacks, coordinated charge, grab, Unit Cohesion", null);
            humanGargantuanUnitTemplate.CharSize = CharacterSize.CharacterSizeEnum.Gargantuan;
            humanGargantuanUnitTemplate.ConsumeTemplate(templateToMerge);
            return humanGargantuanUnitTemplate;
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
