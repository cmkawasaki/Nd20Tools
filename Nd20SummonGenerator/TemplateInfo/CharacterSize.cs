using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    public class CharacterSize
    {
        public enum CharacterSizeEnum
        {
            NOT_DEFINED = -5,
            Fine = -4,
            Diminutive = -3,
            Tiny = -2,
            Small = -1,
            Medium = 0,
            Large = 1,
            Huge = 2,
            Gargantuan = 3,
            Colossal = 4
        }

        public static NPCTemplate CreateSizeTemplate(CharacterSizeEnum size)
        {
            NPCTemplate sizeTemplate = new NPCTemplate("", 0, 0, 0, 0, 0, "class", 0, 0, 0, 0, 0, 0, null, 0, 0, 0, "", null);

            //Add Size bonus to Grapple Checks
            sizeTemplate.TemplateAttacks.AddAttackMod(((int)size) * 4, false, false, true);

            int attackDefenseBonus = CalculateAttackDefenseMod(size);

            if (attackDefenseBonus != 0)
            {
                //Add Size Bonus to attacks
                sizeTemplate.TemplateAttacks.AddAttackMod(attackDefenseBonus, true, true, false);
                //Add Size Bonus to Defense
                sizeTemplate.TemplateDefense.AddModifier("size", attackDefenseBonus, false, false);
            }

            return sizeTemplate;
        }

        private static int CalculateAttackDefenseMod(CharacterSizeEnum size)
        {
            switch (size)
            {
                case CharacterSizeEnum.Colossal:
                    return -8;
                case CharacterSizeEnum.Gargantuan:
                    return -4;
                case CharacterSizeEnum.Huge:
                    return -2;
                case CharacterSizeEnum.Large:
                    return -1;
                case CharacterSizeEnum.Medium:
                    return 0;
                case CharacterSizeEnum.Small:
                    return 1;
                case CharacterSizeEnum.Tiny:
                    return 2;
                case CharacterSizeEnum.Diminutive:
                    return 4;
                case CharacterSizeEnum.Fine:
                    return 8;
                default:
                    return 0;
            }
        }

        public static string PrintFightingSpace(CharacterSizeEnum size)
        {
            switch (size)
            {
                case CharacterSizeEnum.Colossal:
                    return "30 ft by 30 ft;";
                case CharacterSizeEnum.Gargantuan:
                    return "20 ft by 20 ft;";
                case CharacterSizeEnum.Huge:
                    return "15 ft by 15 ft;";
                case CharacterSizeEnum.Large:
                    return "10 ft by 10 ft;";
                case CharacterSizeEnum.Medium:
                    return "5 ft by 5 ft;";
                case CharacterSizeEnum.Small:
                    return "5 ft by 5 ft;";
                case CharacterSizeEnum.Tiny:
                    return "2 1/2 ft by 2 1/2 ft;";
                case CharacterSizeEnum.Diminutive:
                    return "1 ft by 1 ft;";
                case CharacterSizeEnum.Fine:
                    return "6 in by 6 in;";
                default:
                    return "5 ft by 5 ft;";
            }
        }

        public static int CalculateReach(CharacterSizeEnum size)
        {
            switch (size)
            {
                case CharacterSizeEnum.Colossal:
                    return 15;
                case CharacterSizeEnum.Gargantuan:
                    return 15;
                case CharacterSizeEnum.Huge:
                    return 10;
                case CharacterSizeEnum.Large:
                    return 10;
                case CharacterSizeEnum.Medium:
                    return 5;
                case CharacterSizeEnum.Small:
                    return 5;
                case CharacterSizeEnum.Tiny:
                    return 0;
                case CharacterSizeEnum.Diminutive:
                    return 0;
                case CharacterSizeEnum.Fine:
                    return 0;
                default:
                    return 5;
            }
        }

        public static string ReturnSizeText(CharacterSizeEnum size)
        {
            if (size == CharacterSizeEnum.Medium)
            {
                return "Medium-sized";
            }
            else
            {
                return size.ToString();
            }
        }
    }
}
