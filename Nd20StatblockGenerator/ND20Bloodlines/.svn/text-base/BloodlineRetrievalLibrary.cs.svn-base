using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace ND20Bloodlines
{
    [Serializable]
    public class BloodlineRetrievalLibrary
    {
        public List<XMLBloodline> BloodlineList = new List<XMLBloodline>();

        public BloodlineRetrievalLibrary()
        {

        }

        private static BloodlineRetrievalLibrary _Instance = null;

        private static BloodlineRetrievalLibrary Initialize()
        {
            if (_Instance == null)
            {
                //Write Serialization Code here
                StreamReader Reader = new StreamReader(".\\Bloodlines.xml");

                XmlSerializer serializer = new XmlSerializer(typeof(BloodlineRetrievalLibrary));

                _Instance = (BloodlineRetrievalLibrary)serializer.Deserialize(Reader);

                return _Instance;
            }
            else
            {
                return _Instance;
            }
        }

        public static void FillBloodlineDropdown(ComboBox lComboBox)
        {
            BloodlineRetrievalLibrary MyLib = Initialize();

            int Counter = 1;

            lComboBox.Items.Clear();
            lComboBox.Items.Insert(0, "No Bloodline");

            if (MyLib != null || MyLib.BloodlineList != null)
            {
                foreach (XMLBloodline MyBloodline in MyLib.BloodlineList)
                {
                    lComboBox.Items.Insert(Counter, MyBloodline.BloodlineTitle);
                    Counter++;
                }
            }

            lComboBox.SelectedIndex = 0;
        }

        public static int getECLAddition(int BloodlineIndex, int CharacterLevel)
        {
            BloodlineRetrievalLibrary MyLib = Initialize();

            if (MyLib == null || MyLib.BloodlineList == null || BloodlineIndex > MyLib.BloodlineList.Count)
            {
                throw new IndexOutOfRangeException("Bloodline Index is greater than the size of the Bloodline Library.");
            }
            else if (BloodlineIndex == 0)
            {
                //No-Op
                return 0;
            }
            else
            {
                return MyLib.BloodlineList[BloodlineIndex - 1].GetECLByLevel(CharacterLevel);
            }           
        }

        public static string GetBloodlineSQ(int BloodlineIndex, int CharacterLevel)
        {
            BloodlineRetrievalLibrary MyLib = Initialize();

            if(MyLib == null || MyLib.BloodlineList == null || BloodlineIndex > MyLib.BloodlineList.Count)
            {
                throw new IndexOutOfRangeException("Bloodline Index is greater than the size of the Bloodline Library.");
            }
            else if (BloodlineIndex == 0)
            {
                //No-Op
                return "";
            }
            else
            {
                return MyLib.BloodlineList[BloodlineIndex - 1].GetBloodlineTextByLevel(CharacterLevel);
            }            
        }

        public static string GetBloodlineDefenseText(int BloodlineIndex)
        {
            BloodlineRetrievalLibrary MyLib = Initialize();

            if (MyLib == null || MyLib.BloodlineList == null || BloodlineIndex > MyLib.BloodlineList.Count)
            {
                throw new IndexOutOfRangeException("Bloodline Index is greater than the size of the Bloodline Library.");
            }
            else if (BloodlineIndex == 0)
            {
                //No-Op
                return "";
            }
            else
            {
                return MyLib.BloodlineList[BloodlineIndex - 1].BloodlineDefenseName;
            }
        }

        public static BloodlineTemplate GetBloodlineTemplate(int BloodlineIndex, int CharacterLevel)
        {
            BloodlineRetrievalLibrary MyLib = Initialize();

            if (MyLib == null || MyLib.BloodlineList == null || BloodlineIndex > MyLib.BloodlineList.Count)
            {
                throw new IndexOutOfRangeException("Bloodline Index is greater than the size of the Bloodline Library.");
            }
            else if (BloodlineIndex == 0)
            {
                //No-Op
                return null;
            }
            else
            {
                return MyLib.BloodlineList[BloodlineIndex - 1].GetBloodlineTemplateByLevel(CharacterLevel);
            }  
        }

        //TODO: Insert Static function to export Bloodline Template
        public static void RunTests()
        {
            BloodlineRetrievalLibrary MyLib = new BloodlineRetrievalLibrary();

            XMLBloodline MyBloodlineTest = new XMLBloodline();

            MyBloodlineTest.BloodlineTitle = "Sharingan Eye, Intermediate";
            MyBloodlineTest.BloodlineDefenseName = "Sharingan";

            MyBloodlineTest.ListOfAbilities = new List<BloodlineAbility>();

            MyBloodlineTest.BloodlineType = BloodlineClassification.INTERMEDIATE;

            BloodlineAbility SharinganEye = new BloodlineAbility();

            SharinganEye.AbilityText = "sharingan eye +[value]";
            SharinganEye.GrowthList = new List<BloodlineMapping>();

            SharinganEye.GrowthList.Add(new BloodlineMapping(2, 1, "1"));
            SharinganEye.GrowthList.Add(new BloodlineMapping(6, 2, "2"));
            SharinganEye.GrowthList.Add(new BloodlineMapping(8, 3, "3"));
            SharinganEye.GrowthList.Add(new BloodlineMapping(11, 4, "4"));
            SharinganEye.GrowthList.Add(new BloodlineMapping(14, 5, "5"));
            SharinganEye.GrowthList.Add(new BloodlineMapping(19, 6, "6"));

            SharinganEye.AbilityTemplate = new BloodlineTemplate();

            SharinganEye.AbilityTemplate.InitBonus = 1;
            SharinganEye.AbilityTemplate.DefenseBonus = 1;

            MyBloodlineTest.ListOfAbilities.Add(SharinganEye);

            //Offensive Foresight
            BloodlineAbility OffensiveForeSight = new BloodlineAbility();

            OffensiveForeSight.AbilityText = "offensive foresight +[value]";
            OffensiveForeSight.GrowthList = new List<BloodlineMapping>();

            OffensiveForeSight.GrowthList.Add(new BloodlineMapping(3, 1, "1"));
            OffensiveForeSight.GrowthList.Add(new BloodlineMapping(7, 2, "2"));
            OffensiveForeSight.GrowthList.Add(new BloodlineMapping(16, 3, "3"));

            OffensiveForeSight.AbilityTemplate = new BloodlineTemplate();
            OffensiveForeSight.AbilityTemplate.AttackBonus = 1;
            OffensiveForeSight.AbilityTemplate.ReflexBonus = 1;

            MyBloodlineTest.ListOfAbilities.Add(OffensiveForeSight);

            //High Speed Sight
            BloodlineAbility HighSpeedSight = new BloodlineAbility();

            HighSpeedSight.AbilityText = "high speed sight [value]";
            HighSpeedSight.GrowthList = new List<BloodlineMapping>();

            HighSpeedSight.GrowthList.Add(new BloodlineMapping(4, 1, "1"));
            HighSpeedSight.GrowthList.Add(new BloodlineMapping(12, 2, "2"));
            HighSpeedSight.GrowthList.Add(new BloodlineMapping(15, 3, "3"));
            HighSpeedSight.GrowthList.Add(new BloodlineMapping(18, 4, "4"));
            HighSpeedSight.GrowthList.Add(new BloodlineMapping(20, 5, "5"));

            MyBloodlineTest.ListOfAbilities.Add(HighSpeedSight);

            //High Speed Sight
            BloodlineAbility Glare = new BloodlineAbility();

            Glare.AbilityText = "glare";
            Glare.GrowthList = new List<BloodlineMapping>();

            Glare.GrowthList.Add(new BloodlineMapping(10, 0, null));

            MyBloodlineTest.ListOfAbilities.Add(Glare);

            MyLib.BloodlineList.Add(MyBloodlineTest);

            XmlSerializer serializer = new XmlSerializer(typeof(BloodlineRetrievalLibrary));

            TextWriter Writer = new StreamWriter(".\\Output.xml");

            serializer.Serialize(Writer, MyLib);

            Writer.Close();

            System.Console.WriteLine(MyBloodlineTest.GetBloodlineTextByLevel(1));

            System.Console.WriteLine(MyBloodlineTest.GetBloodlineTextByLevel(9));

            System.Console.WriteLine(MyBloodlineTest.GetBloodlineTextByLevel(20));

            BloodlineTemplate Temp = MyBloodlineTest.GetBloodlineTemplateByLevel(20);

            return;
        }
    }
}
