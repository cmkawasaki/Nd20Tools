using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{

    public class ClassStatEntry
    {
        public string ClassName;
        public int ClassLevel;
        public int HDType;
        //public int BonusHP;
        public string TalentList;
        public int SkillPointCount;

        public ClassStatEntry()
        {

        }

        public ClassStatEntry(string MyClassName, int Level, int ClassHDType, string ClassTalents, int SPCount)
        {
            ClassName = MyClassName;
            ClassLevel = Level;
            HDType = ClassHDType;
            TalentList = ClassTalents;
            SkillPointCount = SPCount;
        }

        public string ToStringRTF(int ConMod, int BonusHPFromPower)
        {
            string ReturnString = "";

            ReturnString += ClassLevel + "d" + HDType;
            if (ConMod > 0)
            {
                ReturnString += "+";
            }

            if (ConMod != 0)
            {
                ReturnString += (ConMod * ClassLevel).ToString();
            }

            if (BonusHPFromPower > 0)
            {
                ReturnString += " plus " + (BonusHPFromPower * ClassLevel);
            }

            return ReturnString;
        }

        public static string PrintClassHeaderEntries(List<ClassStatEntry> MyList)
        {
            bool mySwitch = false;
            string returnString = "";

            if (null != MyList)
            {
                foreach (ClassStatEntry MyEntry in MyList)
                {
                    if (true == mySwitch)
                    {
                        returnString += "/";
                    }
                    returnString += MyEntry.ClassName + " " + MyEntry.ClassLevel.ToString();
                    mySwitch = true;
                }
            }

            return returnString;
        }

        public static string PrintHDAndHPEntries(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower, int AverageHP)
        {
            string ReturnString = "";

            //HD
            ReturnString += RTFWriter.FormatWithBold("HD");
            ReturnString += " ";

            bool FirstEntry = true;

            if (null != MyList)
            {
                foreach (ClassStatEntry MyEntry in MyList)
                {
                    if (true == FirstEntry)
                    {
                        FirstEntry = false;
                    }
                    else
                    {
                        ReturnString += " plus ";
                    }

                    ReturnString += MyEntry.ToStringRTF(ConMod, BonusHPFromPower);
                }
            }

            ReturnString += "; ";

            ReturnString += RTFWriter.FormatWithBold("hp");

            ReturnString += " " + AverageHP.ToString() + "; ";

            return ReturnString;
        }

        public static string PrintTalentEntries(List<ClassStatEntry> MyList)
        {
            /*
             *      CharFile.WriteBold("Talent (" + Nd20StatBlockLib.ClassNames[NewChar.MyClasses[i]] + "):");
                    CharFile.Write(" ");
                    CharFile.WriteLine(Nd20StatBlockLib.GetTalentsByClass(NewChar.MyLevels[i], NewChar.MyClasses[i]));
             * */

            string returnString = "";

            if (null != MyList)
            {
                foreach (ClassStatEntry MyEntry in MyList)
                {
                    returnString += RTFWriter.FormatWithBold("Talent (" + MyEntry.ClassName + "):");
                    returnString += " ";
                    returnString += MyEntry.TalentList + RTFWriter.ReturnRTFReturn();
                }
            }

            return returnString;
        }

        public static int GetTotalLevel(List<ClassStatEntry> MyList)
        {
            int TotalLevel = 0;

            if (null != MyList)
            {
                foreach (ClassStatEntry MyEntry in MyList)
                {
                    TotalLevel += MyEntry.ClassLevel;
                }
            }

            return TotalLevel;
        }

        public static string PrintSkillEntry(List<ClassStatEntry> MyList)
        {
            string returnString = "";
            int TotalSkills = 0;

            if (null != MyList)
            {
                returnString += " (";
                for(int i = 0; i < MyList.Count; i++)
                {
                    if (i != 0)
                    {
                        returnString += ", ";
                    }

                    returnString += MyList[i].SkillPointCount + " from " + MyList[i].ClassName;
                    TotalSkills += MyList[i].SkillPointCount;
                }
                returnString += ", total " + TotalSkills + ")";
            }

            return returnString;
        }

        #region Private Variables
        private static int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower)
        {
            int AveHP = 0;
            int TotalLevel = 0;

            foreach (ClassStatEntry MyEntry in MyList)
            {
                AveHP += (int)(((MyEntry.HDType / 2) + ConMod + BonusHPFromPower + .5) * MyEntry.ClassLevel);
                TotalLevel += MyEntry.ClassLevel;
            }

            AveHP = GetMax(TotalLevel, AveHP);

            return AveHP;
        }
        private static int GetMax(int A, int B)
        {
            if (A > B)
                return A;
            else
                return B;
        }
        #endregion
    }
}
