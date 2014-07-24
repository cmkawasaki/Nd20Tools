using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using Nd20TemplateLib;

namespace Nd20StatblockGenerator.CharacterClasses
{
    [XmlRoot]
    public class SummonMetadataList
    {
        public List<SummonMetadata> SummonList = new List<SummonMetadata>();

        private static SummonMetadataList MyList;

        public SummonMetadataList()
        {

        }

        public static SummonMetadataList Initialize()
        {
            if (null == MyList)
            {
                MyList = new SummonMetadataList();
                MyList.SummonList = new List<SummonMetadata>();
            }

            return MyList;
        }

        public static SummonMetadataList Initialize(string FileName)
        {
            if (null == MyList)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SummonMetadataList));
                TextReader Reader = new StreamReader(FileName);

                MyList = (SummonMetadataList)serializer.Deserialize(Reader);

                Reader.Close();
            }

            return MyList;
        }

        public void Save(string FileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SummonMetadataList));
                TextWriter writer = new StreamWriter(FileName);

                serializer.Serialize(writer, this);

                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void PopulateSummonTypeCB(ComboBox lComboBox)
        {
            int Counter = 1;

            lComboBox.Items.Clear();
            lComboBox.Items.Insert(0, "Pick a Type");

            SummonMetadataList MyCharacterList = Initialize();

            //Base Only
            foreach (SummonMetadata MyClass in MyCharacterList.SummonList)
            {
                lComboBox.Items.Insert(Counter, MyClass.ClassTitle);
                Counter++;
            }

            lComboBox.SelectedIndex = 0;
        }

        public static void PopulateSummonRankCB(ComboBox lComboBox, string summonName)
        {
            int Counter = 1;

            lComboBox.Items.Clear();
            lComboBox.Items.Insert(0, "Pick a Type");

            SummonMetadataList MyCharacterList = Initialize();

            foreach (SummonMetadata metadata in MyCharacterList.SummonList)
            {
                if (summonName == metadata.ClassTitle)
                {
                    foreach (XMLRace race in metadata.RankList)
                    {
                        lComboBox.Items.Insert(Counter, race.Name);
                        Counter++;
                    }
                    break;
                }
            }
        }

        public static XMLRace TakeRaceFromDropDown(ComboBox lComboBox, ComboBox lComboBox2)
        {
            SummonMetadataList MyCharacterList = Initialize();

            foreach (SummonMetadata metadata in MyCharacterList.SummonList)
            {
                if ((string)lComboBox.SelectedItem == metadata.ClassTitle)
                {
                    foreach (XMLRace race in metadata.RankList)
                    {
                        if ((string)lComboBox2.SelectedItem == race.Name)
                        {
                            return race;
                        }
                    }
                    break;
                }
            }

            throw new InvalidDataException("Tried to Retrieve a Race not loaded into the Racial List!  Aborting!");
        }
    }
}
