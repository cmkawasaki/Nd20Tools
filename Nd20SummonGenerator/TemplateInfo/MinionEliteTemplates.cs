using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Nd20StatblockGenerator;
using System.Xml.Serialization;
using System.IO;

namespace Nd20TemplateLib
{
    public class MinionEliteTemplates
    {
        public enum CharacterType
        {
            MINION,
            NORMAL,
            ELITE,
            BOSS
        }

        public static List<XMLRace> RaceList;

        public static void FillRaceDropdown(ComboBox lComboBox)
        {
            lComboBox.Items.Clear();

            XmlSerializer serializer = new XmlSerializer(typeof(List<XMLRace>));
            TextReader reader = new StreamReader(".\\Races.xml");
            RaceList = (List<XMLRace>)serializer.Deserialize(reader);

            for (int i = 0; i < RaceList.Count; i++)
            {
                lComboBox.Items.Insert(i, RaceList[i].Name);
            }

            if (lComboBox.Items.Count > 0)
            {
                lComboBox.SelectedIndex = 0;
            }

            //Add-Remove This line to lock race
            //lComboBox.Enabled = false;
        }

        public static void FillMinionEliteDropDown(ComboBox lComboBox)
        {
            lComboBox.Items.Clear();

            lComboBox.Items.Insert(0, "Normal");
            lComboBox.Items.Insert(1, "Minion");
            lComboBox.Items.Insert(2, "Elite");
            lComboBox.Items.Insert(3, "Boss");
            lComboBox.Items.Insert(4, "Solo");
            lComboBox.Items.Insert(5, "Ultra");
            lComboBox.Items.Insert(6, "End Boss");

            lComboBox.SelectedIndex = 0;
        }

        public static void FillBunshinDropDown(ComboBox lComboBox)
        {
            lComboBox.Items.Clear();

            lComboBox.Items.Insert(0, "None");
            lComboBox.Items.Insert(1, "Kage Bunshin");
            lComboBox.Items.Insert(2, "Yuki Bunshin");


            lComboBox.SelectedIndex = 0;
        }

        public static ICharacterType TakeBunshinTypeFromDropDown(ComboBox lComboBox)
        {
            switch (lComboBox.SelectedIndex)
            {
                case 0:
                    return new NormalType();
                case 1:
                    return new KageBunshinType();
                case 2:
                    return new YukiBunshinType();
                default:
                    return new NormalType();
            }
        }


        public static ICharacterType TakeCharacterTypeFromDropDown(ComboBox lComboBox)
        {
            switch (lComboBox.SelectedIndex)
            {
                case 0:
                    return new NormalType();
                case 1:
                    return new MinionType();
                case 2:
                    return new EliteType();
                case 3:
                    return new BossType();
                case 4:
                    return new SoloType();
                case 5:
                    return new UltraType();
                case 6:
                    return new EndBossType();
                default:
                    return new NormalType();
            }
        }

    }
}
