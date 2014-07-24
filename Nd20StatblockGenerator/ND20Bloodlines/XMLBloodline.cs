using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ND20Bloodlines
{
    public enum BloodlineClassification
    {
        MINOR,
        INTERMEDIATE,
        MAJOR
    }

    [Serializable]
    public class XMLBloodline
    {

        public string BloodlineTitle = "Not Set";

        public string BloodlineDefenseName = "Not Set";

        public BloodlineClassification BloodlineType = BloodlineClassification.MINOR;

        public List<BloodlineAbility> ListOfAbilities = new List<BloodlineAbility>();

        public XMLBloodline()
        {

        }

        #region Public Interface
        public int GetECLByLevel(int LevelOfCharacter)
        {
            switch (BloodlineType)
            {
                case BloodlineClassification.MAJOR:
                    if (LevelOfCharacter >= 6 && LevelOfCharacter <= 10)
                        return 1;
                    else if (LevelOfCharacter >= 11 && LevelOfCharacter <= 15)
                        return 2;
                    else if (LevelOfCharacter >= 16)
                        return 3;
                    else
                        return 0;
                case BloodlineClassification.INTERMEDIATE:
                    if (LevelOfCharacter >= 6 && LevelOfCharacter <= 12)
                        return 1;
                    else if (LevelOfCharacter >= 13)
                        return 2;
                    else
                        return 0;
                case BloodlineClassification.MINOR:
                    if (LevelOfCharacter >= 7)
                        return 1;
                    else
                        return 0;
                default:
                    return 0;
            }
        }

        public string GetBloodlineTextByLevel(int LevelOfCharacter)
        {
            bool FirstEntry = true;
            StringBuilder ReturnString = new StringBuilder("");

            if (ListOfAbilities == null || ListOfAbilities.Count == 0)
            {
                return "";
            }
            else
            {
                foreach (BloodlineAbility AbilityToTest in ListOfAbilities)
                {
                    BloodlineMapping MyMapping = null;

                    if (AbilityToTest.GrowthList != null)
                    {
                        MyMapping = FetchLatestMapping(LevelOfCharacter, AbilityToTest);

                        //If Ability gained, print
                        if (MyMapping != null)
                        {
                            if (FirstEntry == false)
                            {
                                ReturnString.Append(", ");
                            }
                            else
                            {
                                FirstEntry = false;
                            }
                            ReturnString.Append(AbilityToTest.AbilityText.Replace("[value]", MyMapping.Text));
                        }   
                    }
                }
            }

            return ReturnString.ToString();
        }

        private static BloodlineMapping FetchLatestMapping(int LevelOfCharacter, BloodlineAbility AbilityToTest)
        {
            BloodlineMapping MyMapping = null;

            foreach (BloodlineMapping MappingToTest in AbilityToTest.GrowthList)
            {
                if (MappingToTest.Level <= LevelOfCharacter)
                {
                    MyMapping = MappingToTest;
                }
            }
            return MyMapping;
        }

        public BloodlineTemplate GetBloodlineTemplateByLevel(int LevelOfCharacter)
        {
            BloodlineTemplate TemplateToReturn = new BloodlineTemplate();

            if (ListOfAbilities == null || ListOfAbilities.Count == 0)
            {
                return TemplateToReturn;
            }
            else
            {
                foreach (BloodlineAbility AbilityToTest in ListOfAbilities)
                {
                    BloodlineMapping MyMapping = null;

                    if (AbilityToTest.GrowthList != null)
                    {
                        MyMapping = FetchLatestMapping(LevelOfCharacter, AbilityToTest);

                        //If Ability gained, print
                        if (MyMapping != null && AbilityToTest.AbilityTemplate != null)
                        {
                            BloodlineTemplate Temp = new BloodlineTemplate();

                            Temp.ConsumeTemplate(AbilityToTest.AbilityTemplate);

                            Temp.MultiplyTemplate(MyMapping.AttackValue);

                            TemplateToReturn.ConsumeTemplate(Temp);
                        }
                    }
                }
            }

            return TemplateToReturn;
        }

        #endregion
    }
}
