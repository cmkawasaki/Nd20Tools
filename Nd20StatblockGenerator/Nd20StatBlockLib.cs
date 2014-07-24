using System;
using Nd20TemplateLib;
using System.Collections.Generic;

/*
statblocklib.c comments
class corresponds to the classes of nd20, namely:
1 - Strong Hero
2 - Fast Hero
3 - Tough Hero
4 - Smart Hero
5 - Dedicated Hero
6 - Charismatic Hero
7 - Elementalist
8 - Elite Shinobi Swordsman
9 - Medical Specialist
10 - Ninja Operations Counter
11 - Ninja Police
12 - Ninja Scout
13 - Puppeteer
14 - Shuriken Expert
15 - Swordsman
16 - Taijutsu Master
17 - Genjutsu Adept
18 - Undying Shinobi
*/
//private helper functions

namespace Nd20StatblockGenerator
{

	/// <summary>
	/// Summary description for Nd20StatBlockLib.
	/// </summary>
	public class Nd20StatBlockLib
	{

		public Nd20StatBlockLib()
		{
		}

		public static string PrintOutCharSkills(CharacterStats BaseStats, int MyPUCount)
		{
			string myString = "";
            myString += "Balance +" + (BaseStats.DexMod + (2 * MyPUCount)) + " (0)";
			myString += ", Chakra Control +" + BaseStats.WisMod + " (0)";
			myString += ", Climb +" + (BaseStats.StrMod + (2 * MyPUCount)) + " (0)";
			myString += ", Genjutsu +" + BaseStats.WisMod + " (0)";
			myString += ", Hide +" + (BaseStats.DexMod + (2 * MyPUCount)) + " (0)";
            myString += ", Jump +" + (BaseStats.StrMod + (2 * MyPUCount)) + " (0)";
            myString += ", Listen +" + (BaseStats.WisMod + (2 * MyPUCount)) + " (0)";
            myString += ", Move Silently +" + (BaseStats.DexMod + (2 * MyPUCount)) + " (0)";
			myString += ", Ninjutsu +" + BaseStats.IntMod + " (0)";
            myString += ", Spot +" + (BaseStats.WisMod + (2 * MyPUCount)) + " (0)";
            myString += ", Swim +" + (BaseStats.StrMod + (2 * MyPUCount)) + " (0)";
            myString += ", Taijutsu +" + BaseStats.StrMod + " (0)";
            myString += ", Tumble +" + (BaseStats.DexMod + (2 * MyPUCount)) + " (0)";

			myString += ".";
			return myString;
		}

        public static NPCTemplate CreatePUTemplate(int PowerUnits)
        {
            int Half = (int)(PowerUnits /2);

            int Spots = (int)Math.Round(((double)(((double)PowerUnits * 2) / 5)), 0);
			int SpeedIncrease = (5 * Spots);

            NPCTemplate PowerUnitTemplate = new NPCTemplate("", Half, Half, (2 * PowerUnits), 0, 0, "power units", Half, PowerUnits, PowerUnits, PowerUnits, 0, (2 * PowerUnits), null, PowerUnits, 0, SpeedIncrease, "", null);

            PowerUnitTemplate.MySpecialTemplates.Add(PowerUnits.ToString() + " power units");

            PowerUnitTemplate.BonusHPFromTemplate = Half;

            PowerUnitTemplate.TemplateAttacks.AddAttackMod(PowerUnits, true, true, false);

            return PowerUnitTemplate;
        }

        public static NPCTemplate CreatePowerRankTemplate(int PowerRanks, NPCTemplate BaseTemplate)
        {
            //int Double = PowerRanks * 2;

            int EpicDR = Math.Min(PowerRanks * 2, 30);

            int ChakraBonus = 15 * PowerRanks;

            string PRSQString = "enlightened traits";
                
            PRSQString += ", damage reduction " + EpicDR + "/epic, elemental resistance " + 2 * PowerRanks + " (any three types), enlightened abilities (any " + (PowerRanks + 1) + "), block sensing, enlightened halo";

            NPCTemplate PRTemplate = new NPCTemplate("", 0, 0, 0, 0, PowerRanks, "divine", PowerRanks, PowerRanks, PowerRanks, PowerRanks, 0, ChakraBonus, null, 0, 0, BaseTemplate.CharacterSpeed, PRSQString, null);

            PRTemplate.MySpecialTemplates.Add(PowerRanks + " power ranks");

            if (2 <= PowerRanks)
            {
                PRTemplate.TemplateDefense.AddModifier("natural", 5, false, true);
            }

            PRTemplate.BonusHPFromTemplate = PowerRanks;

            return PRTemplate;
        }

        public static NPCTemplate CreateStrRankTemplate(int StrRanks)
        {
            int BonusToAttackAndDamage;
            int BonusToGrapple;
            int DRAgainstDarkIron;
            string sqText = "";

            if (StrRanks >= 10)
                DRAgainstDarkIron = 8;
            else if (StrRanks >= 9)
                DRAgainstDarkIron = 6;
            else if (StrRanks >= 8)
                DRAgainstDarkIron = 5;
            else if (StrRanks >= 7)
                DRAgainstDarkIron = 3;
            else if (StrRanks >= 6)
                DRAgainstDarkIron = 2;
            else
                DRAgainstDarkIron = 0;

            if (StrRanks >= 10)
                BonusToAttackAndDamage = 6;
            else if (StrRanks >= 8)
                BonusToAttackAndDamage = 5;
            else if (StrRanks >= 6)
                BonusToAttackAndDamage = 4;
            else if (StrRanks >= 5)
                BonusToAttackAndDamage = 3;
            else if (StrRanks >= 3)
                BonusToAttackAndDamage = 2;
            else
                BonusToAttackAndDamage = 1;

            if (StrRanks >= 10)
                BonusToGrapple = 12;
            else if (StrRanks >= 8)
                BonusToGrapple = 11;
            else if (StrRanks >= 6)
                BonusToGrapple = 10;
            else if (StrRanks >= 5)
                BonusToGrapple = 8;
            else if (StrRanks >= 4)
                BonusToGrapple = 6;
            else if (StrRanks >= 3)
                BonusToGrapple = 4;
            else if (StrRanks >= 2)
                BonusToGrapple = 2;
            else
                BonusToGrapple = 0;

            if (DRAgainstDarkIron > 0)
            {
                sqText = "damage reduction " + DRAgainstDarkIron + "/dark iron";
            }

            NPCTemplate StrRankTemplate = new NPCTemplate(null, 0, 0, 0, 0, 0, "class", 0, 0, 0, 0, 0, 0, null, 0, 0, 0, sqText, null);

            StrRankTemplate.TemplateAttacks.AddAttackMod(BonusToAttackAndDamage, true, false, false);
            StrRankTemplate.TemplateAttacks.AddAttackMod(BonusToGrapple, false, false, true);

            return StrRankTemplate;
        }

        public static NPCTemplate CreateSpeedRankTemplate(int SpeedRanks)
        {
            int NewSpeed;

            if (SpeedRanks >= 10)
                NewSpeed = 60;
            else
                NewSpeed = 5 + (5 * SpeedRanks);

            int Half = (int)(SpeedRanks / 2);

            NPCTemplate SpeedRankTemplate = new NPCTemplate(null, 0, 0, 0, 0, 0, "class", 0, 0, SpeedRanks, 0, 0, 0, null, 0, 0, NewSpeed, "", null);
            SpeedRankTemplate.TemplateAttacks.AddAttackMod(Half, true, true, false);
            SpeedRankTemplate.TemplateDefense.AddModifier("dodge", SpeedRanks, true, false);

            return SpeedRankTemplate;
        }
	}
}
