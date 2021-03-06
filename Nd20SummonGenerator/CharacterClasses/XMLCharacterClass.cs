﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Nd20TemplateLib;

namespace Nd20TemplateLib
{

    [XmlRoot]
    public class XMLCharacterClass
    {
        //Public Constructor
        public XMLCharacterClass()
        {

        }

        #region Enums
        public enum Classtype
        {
            BASE_CLASS,
            ADVANCED_CLASS,
            EPIC_CLASS
        };

        public enum BABType
        {
            HALF,
            THREE_QUARTERS,
            FULL
        };

        public enum SaveType
        {
            POOR,
            GOOD,
            PRCPROGRESSION
        };

        public enum RepType
        {
            CHARISTMATIC,
            GOOD,
            MODERATE,
            LOW,
            NONE
        };

        public enum ClassDefType
        {
            FAST_HERO,
            SEVEN_GOOD,
            FIVE_ADVANCED,
            FIVE_NORMAL,
            POOR,
            NONE
        };

        public enum BonusChakraType
        {
            HIGH,
            ONE_PER_LEVEL,
            LOW,
            NONE
        }

        public enum BonusReserveType
        {
            HIGH,
            MEDIUM,
            LOW,
            NONE
        }

        #endregion

        #region XML_Node_Data
        /// <summary>
        /// The Title of the Class, in string form.  This is what will be displayed to the end-user as text on a completed statblock.  Example: 'Strong Hero'
        /// </summary>
        [XmlElement]
        public string ClassTitle;

        /// <summary>
        /// The maximum level that one can acquire in this class.
        /// </summary>
        [XmlElement]
        public int MaxLevel;

        /// <summary>
        /// This determines the type of class it is for purposes of showing up in the dropdown menu.
        /// </summary>
        [XmlElement]
        public Classtype Classification;

        /// <summary>
        /// The Type of Die used for HitDice
        /// </summary>
        [XmlElement]
        public int HDType;

        /// <summary>
        /// The number of skill points per level for Non-human characters.
        /// </summary>
        [XmlElement]
        public int SkillPointsPerLevel;

        /// <summary>
        /// The rate in which the Class's BAB is calculated.
        /// </summary>
        [XmlElement]
        public BABType ClassBABRate;

        /// <summary>
        /// The rate in which the Class Gives Fort Save Bonuses
        /// </summary>
        [XmlElement]
        public SaveType FortSaveRate;

        /// <summary>
        /// The rate in which the Class Gives Reflex Save Bonuses
        /// </summary>
        [XmlElement]
        public SaveType ReflexSaveRate;

        /// <summary>
        /// The Rate in which the Class Gives Will Save Bonuses
        /// </summary>
        [XmlElement]
        public SaveType WillSaveRate;

        /// <summary>
        /// The Rate in which the Class gives Rep Bonuses
        /// </summary>
        [XmlElement]
        public RepType ClassReputation;

        /// <summary>
        /// The rate in which the Class gives Defense
        /// </summary>
        [XmlElement]
        public ClassDefType ClassDefense;

        /// <summary>
        /// Rate in Which Bonus Chakra comes
        /// </summary>
        [XmlElement]
        public BonusChakraType ClassBonusChakra;

        [XmlElement]
        public BonusReserveType ClassBonusReserve;

        [XmlElement]
        public List<String> TalentList;
        #endregion

        #region Public Functions
        public void GetClassBAB(ref int ClassBAB, ref int EpicBAB, int Level, int BeginningLevel, int EndingLevel)
        {
            ClassBAB = 0;
            EpicBAB = 0;

            //Check for Valid Level
            if (Level < 0 || Level > MaxLevel)
            {
                throw new Exception("Level cannot be less than 0 or greater than " + MaxLevel);
            }

            ClassBAB = FetchClassBAB(Level);
        }

        public void GetClassDefense(ref int ClassDefense, ref int EpicDefense, int Level, int BeginningLevel, int EndingLevel)
        {
            ClassDefense = 0;
            EpicDefense = 0;

            //Check for Valid Level
            if (Level < 0 || Level > MaxLevel)
            {
                throw new Exception("Level cannot be less than 0 or greater than " + MaxLevel);
            }

            ClassDefense = FetchClassDefense(Level);
        }

        public int GetClassFort(int Level, int BeginningLevel, int EndingLevel)
        {
            //Check for Valid Level
            if (Level < 0 || Level > MaxLevel)
            {
                throw new Exception("Level cannot be less than 0 or greater than " + MaxLevel);
            }

            return FetchClassSave(Level, FortSaveRate);
        }

        public int GetClassRef(int Level, int BeginningLevel, int EndingLevel)
        {
            //Check for Valid Level
            if (Level < 0 || Level > MaxLevel)
            {
                throw new Exception("Level cannot be less than 0 or greater than " + MaxLevel);
            }

            return FetchClassSave(Level, ReflexSaveRate);
        }

        public int GetClassWill(int Level, int BeginningLevel, int EndingLevel)
        {
            //Check for Valid Level
            if (Level < 0 || Level > MaxLevel)
            {
                throw new Exception("Level cannot be less than 0 or greater than " + MaxLevel);
            }

            return FetchClassSave(Level, WillSaveRate);
        }

        public int GetClassRep(int Level, int BeginningLevel, int EndingLevel)
        {
            //Check for Valid Level
            if (Level < 0 || Level > MaxLevel)
            {
                throw new Exception("Level cannot be less than 0 or greater than " + MaxLevel);
            }

            //Non-Epic
            if (BeginningLevel < 21 && EndingLevel < 21)
            {
                return FetchClassRep(Level);
            }
            else if (BeginningLevel < 21 && EndingLevel >= 21)
            {
                int NumberofNormalLevels = 20 - (BeginningLevel - 1);

                int A = CalculateEpicRep(EndingLevel - 20);

                return (FetchClassRep(NumberofNormalLevels) + A);
            }
            else
            {
                //All Epic
                int A = CalculateEpicRep(EndingLevel - 20);
                int B = CalculateEpicRep(BeginningLevel - 21);

                return (A - B);
            }
        }

        public string FetchTalentByLevel(int Level)
        {
            if (Level <= TalentList.Count && Level > 0)
            {
                return TalentList[Level - 1];
            }
            else
            {
                return "";
            }
        }

        public int CalculateSP(int Level, int BeginningLevel, int IntMod, int Bonus)
        {
            int WorkingLevel;

            if (BeginningLevel == 1)
            {
                WorkingLevel = Level + 3;
            }
            else
            {
                WorkingLevel = Level;
            }

            return GetMaximum(WorkingLevel, (WorkingLevel * (this.SkillPointsPerLevel + IntMod + Bonus)));
        }

        public static int GetMaximum(int Value1, int Value2)
        {
            if (Value1 > Value2)
                return Value1;
            else
                return Value2;
        }

        public int CalculateChakra(int Level, int BeginningLevel, int Modifier)
        {
            int WorkingLevel = Level;

            if (BeginningLevel == 1)
            {
                WorkingLevel++;
            }


            return ((WorkingLevel * 2) + (Math.Max(Modifier, 0) * Level) + FetchBonusChakra(Level));
        }

        public int CalculateChakraReserve(int Level)
        {
            return ((2 * Level) + FetchBonusReserve(Level));
        }

        public NPCTemplate CreateClassTemplate(int Level, int StartLevel, int EndLevel, CharacterStats BaseStats, int BonusSkillPoints)
        {
            int ClassSP = CalculateSP(Level, StartLevel, BaseStats.IntMod, BonusSkillPoints);

            ClassStatEntry MyHDEntry = new ClassStatEntry(ClassTitle, Level, HDType, FetchTalentByLevel(Level), ClassSP);

            List<ClassStatEntry> MyHDEntries = new List<ClassStatEntry>();

            MyHDEntries.Add(MyHDEntry);

            int ClassBAB = 0;
            int EpicBAB = 0;

            int ClassDef = 0;
            int EpicDef = 0;

            GetClassDefense(ref ClassDef, ref EpicDef, Level, StartLevel, EndLevel);
            GetClassBAB(ref ClassBAB, ref EpicBAB, Level, StartLevel, EndLevel);
            int ClassBaseFort = GetClassFort(Level, StartLevel, EndLevel);
            int ClassBaseRef = GetClassRef(Level, StartLevel, EndLevel);
            int ClassBaseWill = GetClassWill(Level, StartLevel, EndLevel);

            int ClassRep = GetClassRep(Level, StartLevel, EndLevel);

            int ClassCP = CalculateChakra(Level, StartLevel, BaseStats.ConMod);

            NPCTemplate ClassTemplate = new NPCTemplate(null, Level, Level, 0, ClassBAB, EpicBAB, "class", ClassDef, ClassBaseFort, ClassBaseRef, ClassBaseWill, ClassRep, 
                ClassCP, null, Level, 0, 0, "", MyHDEntries);

            ClassTemplate.ChakraReservePool = CalculateChakraReserve(Level);

            if (EpicDef > 0)
            {
                ClassTemplate.TemplateDefense.AddModifier("epic", EpicDef, false, false);
            }

            return ClassTemplate;
        }
        #endregion

        #region Class Retrieval Functions
        private int FetchClassBAB(int Level)
        {
            switch (ClassBABRate)
            {
                case BABType.FULL:
                    return Level;
                case BABType.THREE_QUARTERS:
                    return (int)(Level * .75);
                case BABType.HALF:
                    return (int)(Level * .5);
                default:
                    return 0;
            }
        }

        private int FetchClassDefense(int Level)
        {
            switch (ClassDefense)
            {
                case ClassDefType.FAST_HERO:
                    return ((int)((.5 * Level) + 3));
                case ClassDefType.SEVEN_GOOD:
                    if (Level == 1)
                        return 1;
                    else if (Level == 2 || Level == 3)
                        return 2;
                    else if (Level == 4)
                        return 3;
                    else if (Level == 5 || Level == 6)
                        return 4;
                    else if (Level == 7)
                        return 5;
                    else if (Level == 8 || Level == 9)
                        return 6;
                    else
                        return 7;
                case ClassDefType.FIVE_ADVANCED:
                    return (int)((Level + 1) / 2);
                case ClassDefType.FIVE_NORMAL:
                    if (Level == 1)
                        return 1;
                    else if (Level == 2 || Level == 3)
                        return 2;
                    else if (Level >= 4 && Level <= 6)
                        return 3;
                    else if (Level == 7 || Level == 8)
                        return 4;
                    else
                        return 5;
                case ClassDefType.POOR:
                    return ((int)((Level + 1) / 3));
                case ClassDefType.NONE:
                    return 0;
                default:
                    return 0;
            } 
        }

        private int FetchClassSave(int Level, SaveType ExpectedSave)
        {
            switch (ExpectedSave)
            {
                case SaveType.PRCPROGRESSION:
                    return ((int)((.5 * Level) + 2));
                case SaveType.GOOD:
                    if (Level == 1)
                        return 1;
                    else if (Level >= 2 && Level <= 4)
                        return 2;
                    else if (Level == 5 || Level == 6)
                        return 3;
                    else if (Level >= 7 && Level <= 9)
                        return 4;
                    else
                        return 5;
                case SaveType.POOR:
                    return ((int)(Level / 3));
                default:
                    return 0;
            }
        }

        private int FetchClassRep(int Level)
        {
            switch (ClassReputation)
            {
                case RepType.CHARISTMATIC:
                    return ((int)((Level + 5) / 3));
                case RepType.GOOD:
                    return ((int)((Level + 2) / 3));
                case RepType.MODERATE:
                    return ((int)(Level / 3));
                case RepType.LOW:
                    return ((int)((Level - 1) / 4));
                case RepType.NONE:
                    return 0;
                default:
                    return 0;
            }
        }

        private int FetchBonusChakra(int Level)
        {
            switch (this.ClassBonusChakra)
            {
                case BonusChakraType.HIGH:
                    return (int)((Level * 2) - 1);
                case BonusChakraType.ONE_PER_LEVEL:
                    return Level;
                case BonusChakraType.LOW:
                    return ((int)(Level / 2));
                case BonusChakraType.NONE:
                    return 0;
                default:
                    return 0;
            }
        }

        private int FetchBonusReserve(int Level)
        {
            switch (this.ClassBonusReserve)
            {
                case BonusReserveType.HIGH:
                    return (int)(Level * 4);
                case BonusReserveType.MEDIUM:
                    return (int)(Level * 2);
                case BonusReserveType.LOW:
                    return Level;
                case BonusReserveType.NONE:
                    return 0;
                default:
                    return 0;
            }
        }

        #endregion

        #region Epic Calculation Functions

        private int CalculateEpicBAB(int Level)
        {
            return ((int)(Level / 2));
        }

        private int CalculateEpicDefense(int Level)
        {
            return ((int)(Level / 3));
        }

        private int CalculateEpicSave(int Level)
        {
            return ((int)((Level+1) / 2));
        }

        private int CalculateEpicRep(int Level)
        {
            return Level;
        }
        #endregion

    }
}
