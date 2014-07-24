using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace Nd20TemplateLib
{
    [XmlRoot]
    public class XMLClassList
    {
        [XmlElement]
        public List<XMLCharacterClass> ClassList = new List<XMLCharacterClass>();

        public XMLClassList()
        {
        }

        private static XMLClassList MyList;

        public static XMLClassList Initialize()
        {
            if (null == MyList)
            {
                MyList = new XMLClassList();
                MyList.ClassList = new List<XMLCharacterClass>();
            }

            return MyList;
        }

        public static XMLClassList Initialize(string FileName)
        {
            if (null == MyList)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(XMLClassList));
                TextReader Reader = new StreamReader(FileName);

                MyList = (XMLClassList)serializer.Deserialize(Reader);

                Reader.Close();
            }

            return MyList;
        }

        public static void SerializeToFile(string FileName, XMLClassList ListToBeSerialized)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XMLClassList));
            TextWriter Writer = new StreamWriter(FileName);

            serializer.Serialize(Writer, ListToBeSerialized);

            Writer.Close();
        }

        public static void PopulateClassCB(ComboBox lComboBox, int CurrentCharacterLevel)
        {
            int Counter = 1;

            lComboBox.Items.Clear();
            lComboBox.Items.Insert(0, "Pick a Class");

            XMLClassList MyCharacterList = Initialize();

            if (0 == CurrentCharacterLevel)
            {
                //Base Only
                foreach (XMLCharacterClass MyClass in MyCharacterList.ClassList)
                {
                    if (MyClass.Classification == XMLCharacterClass.Classtype.BASE_CLASS)
                    {
                        lComboBox.Items.Insert(Counter, MyClass.ClassTitle);
                        Counter++;
                    }
                }

            }
            else if (CurrentCharacterLevel < 20)
            {
                //Base and PrC
                foreach (XMLCharacterClass MyClass in MyCharacterList.ClassList)
                {
                    if (MyClass.Classification == XMLCharacterClass.Classtype.BASE_CLASS || MyClass.Classification == XMLCharacterClass.Classtype.ADVANCED_CLASS)
                    {
                        lComboBox.Items.Insert(Counter, MyClass.ClassTitle);
                        Counter++;
                    }
                }
            }
            else
            {
                //All
                foreach (XMLCharacterClass MyClass in MyCharacterList.ClassList)
                {
                    lComboBox.Items.Insert(Counter, MyClass.ClassTitle);
                    Counter++;
                }
            }

            lComboBox.SelectedIndex = 0;
        }

        public static void PopulateLevelCB(ComboBox lComboBox, string ClassName)
        {
            lComboBox.Items.Clear();
            int ClassLevel = -1;

            XMLClassList MyCharacterList = Initialize();
            
            foreach (XMLCharacterClass MyClass in MyCharacterList.ClassList)
            {
                if (MyClass.ClassTitle.ToLower() == ClassName.ToLower())
                {
                    ClassLevel = MyClass.MaxLevel;
                    break;
                }
            }

            for (int i = 0; i <= ClassLevel; i++)
            {
                lComboBox.Items.Insert(i, i.ToString());
            }
            lComboBox.SelectedIndex = 0;
        }

        public static void PopulatePUCB(ComboBox lComboBox)
        {
            lComboBox.Items.Clear();
            int PU_MAX = 20;

            for (int i = 0; i <= PU_MAX; i++)
            {
                lComboBox.Items.Insert(i, i.ToString());
            }
            lComboBox.SelectedIndex = 0;
        }

        public static void PopulateSpeedStrRankCB(ComboBox lComboBox)
        {
            lComboBox.Items.Clear();
            int PU_MAX = 10;

            for (int i = 0; i <= PU_MAX; i++)
            {
                lComboBox.Items.Insert(i, i.ToString());
            }
            lComboBox.SelectedIndex = 0;
        }
    }
}
