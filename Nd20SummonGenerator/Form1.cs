using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Nd20TemplateLib;
using Nd20StatblockGenerator.CharacterClasses;
using System.Collections.Generic;

namespace Nd20StatblockGenerator
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox tbCName;
		private System.Windows.Forms.Label ClassLabel;
		private System.Windows.Forms.ComboBox cbsummonRank;
		private System.Windows.Forms.ComboBox cbLevel;
		private System.Windows.Forms.Label LevelLabel;
		private System.Windows.Forms.Label strLabel;
		private System.Windows.Forms.Label dexLabel;
		private System.Windows.Forms.Label conLabel;
		private System.Windows.Forms.Label intLabel;
		private System.Windows.Forms.Label wisLabel;
		private System.Windows.Forms.Label chaLabel;
		private System.Windows.Forms.Button GenerateButton;
		private Nd20StatblockGenerator.NumericTextBox tbStr;
		private Nd20StatblockGenerator.NumericTextBox tbDex;
		private Nd20StatblockGenerator.NumericTextBox tbCon;
		private Nd20StatblockGenerator.NumericTextBox tbInt;
		private Nd20StatblockGenerator.NumericTextBox tbWis;
        private Nd20StatblockGenerator.NumericTextBox tbCha;
        private Label CTLabel;
        private ComboBox cbCharType;
        private Label StrRLabel;
        private Label SpeedRLabel;
        private ComboBox cbStrRank;
        private ComboBox cbSpeedRank;
        private Label BunshinLabel;
        private ComboBox cbBunshinType;
        private Label TemplateLabel;
        private ComboBox cbSummonType;
        private Label PRLabel;
        private ComboBox cbPowerRanks;
        private Label strTotalLabel;
        private Label dexTotalLabel;
        private Label conTotalLabel;
        private Label intTotalLabel;
        private Label wisTotalLabel;
        private Label chaTotalLabel;
        private Label statsLabel;
        private Label lSummonCategory;
        private ComboBox cbSummonCategory;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.NameLabel = new System.Windows.Forms.Label();
            this.tbCName = new System.Windows.Forms.TextBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.cbsummonRank = new System.Windows.Forms.ComboBox();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.strLabel = new System.Windows.Forms.Label();
            this.dexLabel = new System.Windows.Forms.Label();
            this.conLabel = new System.Windows.Forms.Label();
            this.intLabel = new System.Windows.Forms.Label();
            this.wisLabel = new System.Windows.Forms.Label();
            this.chaLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CTLabel = new System.Windows.Forms.Label();
            this.cbCharType = new System.Windows.Forms.ComboBox();
            this.StrRLabel = new System.Windows.Forms.Label();
            this.SpeedRLabel = new System.Windows.Forms.Label();
            this.cbStrRank = new System.Windows.Forms.ComboBox();
            this.cbSpeedRank = new System.Windows.Forms.ComboBox();
            this.BunshinLabel = new System.Windows.Forms.Label();
            this.cbBunshinType = new System.Windows.Forms.ComboBox();
            this.TemplateLabel = new System.Windows.Forms.Label();
            this.cbSummonType = new System.Windows.Forms.ComboBox();
            this.PRLabel = new System.Windows.Forms.Label();
            this.cbPowerRanks = new System.Windows.Forms.ComboBox();
            this.strTotalLabel = new System.Windows.Forms.Label();
            this.dexTotalLabel = new System.Windows.Forms.Label();
            this.conTotalLabel = new System.Windows.Forms.Label();
            this.intTotalLabel = new System.Windows.Forms.Label();
            this.wisTotalLabel = new System.Windows.Forms.Label();
            this.chaTotalLabel = new System.Windows.Forms.Label();
            this.statsLabel = new System.Windows.Forms.Label();
            this.lSummonCategory = new System.Windows.Forms.Label();
            this.cbSummonCategory = new System.Windows.Forms.ComboBox();
            this.tbCha = new Nd20StatblockGenerator.NumericTextBox();
            this.tbWis = new Nd20StatblockGenerator.NumericTextBox();
            this.tbInt = new Nd20StatblockGenerator.NumericTextBox();
            this.tbCon = new Nd20StatblockGenerator.NumericTextBox();
            this.tbDex = new Nd20StatblockGenerator.NumericTextBox();
            this.tbStr = new Nd20StatblockGenerator.NumericTextBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(8, 8);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(104, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name of Summon:";
            // 
            // tbCName
            // 
            this.tbCName.Location = new System.Drawing.Point(112, 8);
            this.tbCName.Name = "tbCName";
            this.tbCName.Size = new System.Drawing.Size(216, 20);
            this.tbCName.TabIndex = 1;
            // 
            // ClassLabel
            // 
            this.ClassLabel.Location = new System.Drawing.Point(16, 90);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(80, 24);
            this.ClassLabel.TabIndex = 2;
            this.ClassLabel.Text = "Summon Rank:";
            // 
            // cbsummonRank
            // 
            this.cbsummonRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsummonRank.Location = new System.Drawing.Point(16, 114);
            this.cbsummonRank.Name = "cbsummonRank";
            this.cbsummonRank.Size = new System.Drawing.Size(120, 21);
            this.cbsummonRank.TabIndex = 3;
            this.cbsummonRank.SelectedIndexChanged += new System.EventHandler(this.cbclassNM1_SelectedIndexChanged);
            // 
            // cbLevel
            // 
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.Enabled = false;
            this.cbLevel.Location = new System.Drawing.Point(152, 114);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(48, 21);
            this.cbLevel.TabIndex = 4;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel1_SelectedIndexChanged);
            // 
            // LevelLabel
            // 
            this.LevelLabel.Location = new System.Drawing.Point(152, 90);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(40, 16);
            this.LevelLabel.TabIndex = 5;
            this.LevelLabel.Text = "Level:";
            // 
            // strLabel
            // 
            this.strLabel.Location = new System.Drawing.Point(312, 64);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(32, 16);
            this.strLabel.TabIndex = 6;
            this.strLabel.Text = "Str:";
            // 
            // dexLabel
            // 
            this.dexLabel.Location = new System.Drawing.Point(312, 88);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(32, 16);
            this.dexLabel.TabIndex = 7;
            this.dexLabel.Text = "Dex:";
            // 
            // conLabel
            // 
            this.conLabel.Location = new System.Drawing.Point(312, 112);
            this.conLabel.Name = "conLabel";
            this.conLabel.Size = new System.Drawing.Size(32, 16);
            this.conLabel.TabIndex = 8;
            this.conLabel.Text = "Con:";
            // 
            // intLabel
            // 
            this.intLabel.Location = new System.Drawing.Point(312, 136);
            this.intLabel.Name = "intLabel";
            this.intLabel.Size = new System.Drawing.Size(32, 16);
            this.intLabel.TabIndex = 9;
            this.intLabel.Text = "Int:";
            // 
            // wisLabel
            // 
            this.wisLabel.Location = new System.Drawing.Point(312, 160);
            this.wisLabel.Name = "wisLabel";
            this.wisLabel.Size = new System.Drawing.Size(32, 16);
            this.wisLabel.TabIndex = 10;
            this.wisLabel.Text = "Wis:";
            // 
            // chaLabel
            // 
            this.chaLabel.Location = new System.Drawing.Point(312, 184);
            this.chaLabel.Name = "chaLabel";
            this.chaLabel.Size = new System.Drawing.Size(32, 16);
            this.chaLabel.TabIndex = 11;
            this.chaLabel.Text = "Cha:";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(325, 224);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(64, 32);
            this.GenerateButton.TabIndex = 18;
            this.GenerateButton.Text = "Generate!";
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CTLabel
            // 
            this.CTLabel.AutoSize = true;
            this.CTLabel.Location = new System.Drawing.Point(24, 155);
            this.CTLabel.Name = "CTLabel";
            this.CTLabel.Size = new System.Drawing.Size(83, 13);
            this.CTLabel.TabIndex = 41;
            this.CTLabel.Text = "Character Type:";
            // 
            // cbCharType
            // 
            this.cbCharType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCharType.Location = new System.Drawing.Point(112, 155);
            this.cbCharType.Name = "cbCharType";
            this.cbCharType.Size = new System.Drawing.Size(168, 21);
            this.cbCharType.TabIndex = 42;
            // 
            // StrRLabel
            // 
            this.StrRLabel.AutoSize = true;
            this.StrRLabel.Location = new System.Drawing.Point(24, 191);
            this.StrRLabel.Name = "StrRLabel";
            this.StrRLabel.Size = new System.Drawing.Size(79, 13);
            this.StrRLabel.TabIndex = 43;
            this.StrRLabel.Text = "Strength Rank:";
            // 
            // SpeedRLabel
            // 
            this.SpeedRLabel.AutoSize = true;
            this.SpeedRLabel.Location = new System.Drawing.Point(24, 220);
            this.SpeedRLabel.Name = "SpeedRLabel";
            this.SpeedRLabel.Size = new System.Drawing.Size(70, 13);
            this.SpeedRLabel.TabIndex = 44;
            this.SpeedRLabel.Text = "Speed Rank:";
            // 
            // cbStrRank
            // 
            this.cbStrRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStrRank.Location = new System.Drawing.Point(112, 191);
            this.cbStrRank.Name = "cbStrRank";
            this.cbStrRank.Size = new System.Drawing.Size(48, 21);
            this.cbStrRank.TabIndex = 45;
            // 
            // cbSpeedRank
            // 
            this.cbSpeedRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeedRank.Location = new System.Drawing.Point(112, 220);
            this.cbSpeedRank.Name = "cbSpeedRank";
            this.cbSpeedRank.Size = new System.Drawing.Size(48, 21);
            this.cbSpeedRank.TabIndex = 46;
            // 
            // BunshinLabel
            // 
            this.BunshinLabel.AutoSize = true;
            this.BunshinLabel.Location = new System.Drawing.Point(24, 260);
            this.BunshinLabel.Name = "BunshinLabel";
            this.BunshinLabel.Size = new System.Drawing.Size(75, 13);
            this.BunshinLabel.TabIndex = 47;
            this.BunshinLabel.Text = "Bunshin Type:";
            // 
            // cbBunshinType
            // 
            this.cbBunshinType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBunshinType.Location = new System.Drawing.Point(112, 252);
            this.cbBunshinType.Name = "cbBunshinType";
            this.cbBunshinType.Size = new System.Drawing.Size(168, 21);
            this.cbBunshinType.TabIndex = 48;
            // 
            // TemplateLabel
            // 
            this.TemplateLabel.Location = new System.Drawing.Point(11, 45);
            this.TemplateLabel.Name = "TemplateLabel";
            this.TemplateLabel.Size = new System.Drawing.Size(85, 16);
            this.TemplateLabel.TabIndex = 49;
            this.TemplateLabel.Text = "Summon Type:";
            this.TemplateLabel.Click += new System.EventHandler(this.TemplateLabel_Click);
            // 
            // cbSummonType
            // 
            this.cbSummonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSummonType.Location = new System.Drawing.Point(112, 40);
            this.cbSummonType.Name = "cbSummonType";
            this.cbSummonType.Size = new System.Drawing.Size(168, 21);
            this.cbSummonType.TabIndex = 50;
            this.cbSummonType.SelectedIndexChanged += new System.EventHandler(this.cbTemplate1_SelectedIndexChanged);
            // 
            // PRLabel
            // 
            this.PRLabel.Location = new System.Drawing.Point(22, 293);
            this.PRLabel.Name = "PRLabel";
            this.PRLabel.Size = new System.Drawing.Size(84, 16);
            this.PRLabel.TabIndex = 51;
            this.PRLabel.Text = "Power Ranks:";
            // 
            // cbPowerRanks
            // 
            this.cbPowerRanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPowerRanks.Location = new System.Drawing.Point(112, 288);
            this.cbPowerRanks.Name = "cbPowerRanks";
            this.cbPowerRanks.Size = new System.Drawing.Size(48, 21);
            this.cbPowerRanks.TabIndex = 52;
            // 
            // strTotalLabel
            // 
            this.strTotalLabel.AutoSize = true;
            this.strTotalLabel.Location = new System.Drawing.Point(392, 70);
            this.strTotalLabel.Name = "strTotalLabel";
            this.strTotalLabel.Size = new System.Drawing.Size(0, 13);
            this.strTotalLabel.TabIndex = 53;
            // 
            // dexTotalLabel
            // 
            this.dexTotalLabel.AutoSize = true;
            this.dexTotalLabel.Location = new System.Drawing.Point(392, 93);
            this.dexTotalLabel.Name = "dexTotalLabel";
            this.dexTotalLabel.Size = new System.Drawing.Size(0, 13);
            this.dexTotalLabel.TabIndex = 54;
            // 
            // conTotalLabel
            // 
            this.conTotalLabel.AutoSize = true;
            this.conTotalLabel.Location = new System.Drawing.Point(392, 114);
            this.conTotalLabel.Name = "conTotalLabel";
            this.conTotalLabel.Size = new System.Drawing.Size(0, 13);
            this.conTotalLabel.TabIndex = 55;
            // 
            // intTotalLabel
            // 
            this.intTotalLabel.AutoSize = true;
            this.intTotalLabel.Location = new System.Drawing.Point(392, 139);
            this.intTotalLabel.Name = "intTotalLabel";
            this.intTotalLabel.Size = new System.Drawing.Size(0, 13);
            this.intTotalLabel.TabIndex = 56;
            // 
            // wisTotalLabel
            // 
            this.wisTotalLabel.AutoSize = true;
            this.wisTotalLabel.Location = new System.Drawing.Point(392, 163);
            this.wisTotalLabel.Name = "wisTotalLabel";
            this.wisTotalLabel.Size = new System.Drawing.Size(0, 13);
            this.wisTotalLabel.TabIndex = 57;
            // 
            // chaTotalLabel
            // 
            this.chaTotalLabel.AutoSize = true;
            this.chaTotalLabel.Location = new System.Drawing.Point(392, 191);
            this.chaTotalLabel.Name = "chaTotalLabel";
            this.chaTotalLabel.Size = new System.Drawing.Size(0, 13);
            this.chaTotalLabel.TabIndex = 58;
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.Location = new System.Drawing.Point(384, 45);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(56, 13);
            this.statsLabel.TabIndex = 59;
            this.statsLabel.Text = "Final Stats";
            // 
            // lSummonCategory
            // 
            this.lSummonCategory.AutoSize = true;
            this.lSummonCategory.Location = new System.Drawing.Point(21, 324);
            this.lSummonCategory.Name = "lSummonCategory";
            this.lSummonCategory.Size = new System.Drawing.Size(78, 13);
            this.lSummonCategory.TabIndex = 60;
            this.lSummonCategory.Text = "Summon Type:";
            // 
            // cbSummonCategory
            // 
            this.cbSummonCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSummonCategory.FormattingEnabled = true;
            this.cbSummonCategory.Location = new System.Drawing.Point(112, 324);
            this.cbSummonCategory.Name = "cbSummonCategory";
            this.cbSummonCategory.Size = new System.Drawing.Size(168, 21);
            this.cbSummonCategory.TabIndex = 61;
            // 
            // tbCha
            // 
            this.tbCha.Location = new System.Drawing.Point(344, 184);
            this.tbCha.Name = "tbCha";
            this.tbCha.Size = new System.Drawing.Size(32, 20);
            this.tbCha.TabIndex = 24;
            this.tbCha.Text = "10";
            this.tbCha.TextChanged += new System.EventHandler(this.tbStatTextBox_TextChanged);
            // 
            // tbWis
            // 
            this.tbWis.Location = new System.Drawing.Point(344, 160);
            this.tbWis.Name = "tbWis";
            this.tbWis.Size = new System.Drawing.Size(32, 20);
            this.tbWis.TabIndex = 23;
            this.tbWis.Text = "10";
            this.tbWis.TextChanged += new System.EventHandler(this.tbStatTextBox_TextChanged);
            // 
            // tbInt
            // 
            this.tbInt.Location = new System.Drawing.Point(344, 136);
            this.tbInt.Name = "tbInt";
            this.tbInt.Size = new System.Drawing.Size(32, 20);
            this.tbInt.TabIndex = 22;
            this.tbInt.Text = "10";
            this.tbInt.TextChanged += new System.EventHandler(this.tbStatTextBox_TextChanged);
            // 
            // tbCon
            // 
            this.tbCon.Location = new System.Drawing.Point(344, 112);
            this.tbCon.Name = "tbCon";
            this.tbCon.Size = new System.Drawing.Size(32, 20);
            this.tbCon.TabIndex = 21;
            this.tbCon.Text = "10";
            this.tbCon.TextChanged += new System.EventHandler(this.tbStatTextBox_TextChanged);
            // 
            // tbDex
            // 
            this.tbDex.Location = new System.Drawing.Point(344, 88);
            this.tbDex.Name = "tbDex";
            this.tbDex.Size = new System.Drawing.Size(32, 20);
            this.tbDex.TabIndex = 20;
            this.tbDex.Text = "10";
            this.tbDex.TextChanged += new System.EventHandler(this.tbStatTextBox_TextChanged);
            // 
            // tbStr
            // 
            this.tbStr.Location = new System.Drawing.Point(344, 64);
            this.tbStr.Name = "tbStr";
            this.tbStr.Size = new System.Drawing.Size(32, 20);
            this.tbStr.TabIndex = 19;
            this.tbStr.Text = "10";
            this.tbStr.TextChanged += new System.EventHandler(this.tbStatTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(452, 374);
            this.Controls.Add(this.cbSummonCategory);
            this.Controls.Add(this.lSummonCategory);
            this.Controls.Add(this.statsLabel);
            this.Controls.Add(this.chaTotalLabel);
            this.Controls.Add(this.wisTotalLabel);
            this.Controls.Add(this.intTotalLabel);
            this.Controls.Add(this.conTotalLabel);
            this.Controls.Add(this.dexTotalLabel);
            this.Controls.Add(this.strTotalLabel);
            this.Controls.Add(this.cbPowerRanks);
            this.Controls.Add(this.PRLabel);
            this.Controls.Add(this.cbSummonType);
            this.Controls.Add(this.TemplateLabel);
            this.Controls.Add(this.cbBunshinType);
            this.Controls.Add(this.BunshinLabel);
            this.Controls.Add(this.cbSpeedRank);
            this.Controls.Add(this.cbStrRank);
            this.Controls.Add(this.SpeedRLabel);
            this.Controls.Add(this.StrRLabel);
            this.Controls.Add(this.cbCharType);
            this.Controls.Add(this.CTLabel);
            this.Controls.Add(this.tbCha);
            this.Controls.Add(this.tbWis);
            this.Controls.Add(this.tbInt);
            this.Controls.Add(this.tbCon);
            this.Controls.Add(this.tbDex);
            this.Controls.Add(this.tbStr);
            this.Controls.Add(this.tbCName);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.chaLabel);
            this.Controls.Add(this.wisLabel);
            this.Controls.Add(this.intLabel);
            this.Controls.Add(this.conLabel);
            this.Controls.Add(this.dexLabel);
            this.Controls.Add(this.strLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.cbsummonRank);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Naruto D20 Summon Generator 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
            ////Create Toad
            //SummonMetadataList summon = SummonMetadataList.Initialize();
            //SummonMetadata toad = new SummonMetadata();
            //toad.SummonClass = new XMLCharacterClass();
            //toad.SummonClass.ClassBABRate = XMLCharacterClass.BABType.FULL;
            //toad.SummonClass.ClassBonusChakra = XMLCharacterClass.BonusChakraType.NONE;
            //toad.SummonClass.ClassBonusReserve = XMLCharacterClass.BonusReserveType.NONE;
            //toad.SummonClass.ClassDefense = XMLCharacterClass.ClassDefType.NONE;
            //toad.SummonClass.Classification = XMLCharacterClass.Classtype.BASE_CLASS;
            //toad.SummonClass.ClassReputation = XMLCharacterClass.RepType.NONE;
            //toad..ClassTitle = "Toad";
            //toad.SummonClass.FortSaveRate = XMLCharacterClass.SaveType.POOR;
            //toad.SummonClass.ReflexSaveRate = XMLCharacterClass.SaveType.PRCPROGRESSION;
            //toad.SummonClass.HDType = 8;
            //toad.SummonClass.MaxLevel = 40;
            //toad.SummonClass.SkillPointsPerLevel = 0;
            //List<string> talentlist = new List<string>();
            //for(int i = 0; i < 40; i++)
            //{
            //    talentlist.Add("");
            //}
            //toad.SummonClass.TalentList = talentlist;
            //toad.SummonClass.WillSaveRate = XMLCharacterClass.SaveType.PRCPROGRESSION;

            ////TODO: Add Soldier Rank
            //XMLRace toadSoldier = new XMLRace();
            //toadSoldier.CharacterSpeed = 30;
            //toadSoldier.BonusFeats = 0;
            //toadSoldier.BonusSkillPoints = 0;
            //toadSoldier.ClassCR = 0;
            //toadSoldier.ClassECL = 0;
            //toadSoldier.Name = "Soldier";
            //toadSoldier.HDType = XMLRace.RaceHDType.AVERAGE;
            //toadSoldier.PossessesRacialClass = false;
            //DefenseStat toadNatural = new DefenseStat();
            //toadNatural.AddModifier("natural", 1, false, true);
            //toadSoldier.RacialDefense = toadNatural;
            //toadSoldier.RacialSize = CharacterSize.CharacterSizeEnum.Tiny;
            //toadSoldier.RacialStats = new CharacterStats(-6, 6, -2, -2, +2, -4);
            //toadSoldier.SpecialQualities = "aquatic subtype, amphibious, constrict (1), darkvision 60ft., salt water vulnerability, tongue";
            //toad.RankList.Add(toadSoldier);

            ////TODO: Add Soldier Rank
            //XMLRace toadProtector = new XMLRace();
            //toadProtector.CharacterSpeed = 30;
            //toadProtector.BonusFeats = 0;
            //toadProtector.BonusSkillPoints = 0;
            //toadProtector.ClassCR = 0;
            //toadProtector.ClassECL = 0;
            //toadProtector.Name = "Protector";
            //toadProtector.HDType = XMLRace.RaceHDType.AVERAGE;
            //toadProtector.PossessesRacialClass = false;
            //DefenseStat toadNatural2 = new DefenseStat();
            //toadNatural2.AddModifier("natural", 2, false, true);
            //toadProtector.RacialDefense = toadNatural2;
            //toadProtector.RacialSize = CharacterSize.CharacterSizeEnum.Small;
            //toadProtector.RacialStats = new CharacterStats(0, 8, 0, -2, +3, -4);
            //toadProtector.SpecialQualities = "aquatic subtype, amphibious, constrict (1), darkvision 60ft., salt water vulnerability, tongue";
            //toad.RankList.Add(toadProtector);
            //summon.SummonList.Add(toad);

            //summon.Save(".\\SummonData.xml");

            //Load XML
            try
            {
                SummonMetadataList.Initialize(".\\SummonData.xml");
                SummonMetadataList.PopulateSummonTypeCB(cbSummonType);
                XMLClassList.PopulateClassCB(cbsummonRank, 0);
                XMLClassList.PopulatePUCB(cbPowerRanks);
            }
            catch (Exception Exp)
            {
                MessageBox.Show("Error in the Summon Metadata XML Detected!  Aborting launch of Summon Generator. If this problem persists, please redownload the affected component.");
                Environment.Exit(1);
            }

            MinionEliteTemplates.FillMinionEliteDropDown(cbCharType);
            MinionEliteTemplates.FillBunshinDropDown(cbBunshinType);
            XMLClassList.PopulateSpeedStrRankCB(cbStrRank);
            XMLClassList.PopulateSpeedStrRankCB(cbSpeedRank);

            cbSummonCategory.Items.Insert(0, "Normal");
            cbSummonCategory.Items.Insert(1, "Elite");
            cbSummonCategory.Items.Insert(2, "Paragon");
		}

		private void GenerateButton_Click(object sender, System.EventArgs e)
		{

            if(tbStr.Text == "")
			{
				MessageBox.Show("There must be a value for Str.");
                return;
			}
			else if(tbDex.Text == "")
			{
				MessageBox.Show("There must be a value for Dex.");
                return;
			}
			else if(tbCon.Text == "")
			{
				MessageBox.Show("There must be a value for Con.");
                return;
			}
			else if(tbInt.Text == "")
			{
				MessageBox.Show("There must be a value for Int.");
                return;
			}
			else if(tbWis.Text == "")
			{
				MessageBox.Show("There must be a value for Wis.");
                return;
			}
			else if(tbCha.Text == "")
			{
				MessageBox.Show("There must be a value for Cha.");
                return;
			}

            CharacterStats NewCharBaseStats = new CharacterStats(Convert.ToInt32(tbStr.Text), Convert.ToInt32(tbDex.Text), Convert.ToInt32(tbCon.Text),
                Convert.ToInt32(tbInt.Text), Convert.ToInt32(tbWis.Text), Convert.ToInt32(tbCha.Text));

            string[] MyClasses = new string[1];
            int[] MyLevels = new int[1];

			//Fill In Class and Levels from Form
            if (cbSummonType.Enabled == true && cbSummonType.SelectedIndex > 0 && cbLevel.SelectedIndex > 0)
			{
				MyClasses[0] = cbSummonType.Text;
				MyLevels[0] = cbLevel.SelectedIndex * 2;
			}
			else
			{
                MessageBox.Show("There must at least one class declared.");
                return;
			}
            
            int MyPRCount = cbPowerRanks.SelectedIndex;

            ICharacterType CharType = MinionEliteTemplates.TakeCharacterTypeFromDropDown(cbCharType);
            ICharacterType BunshinType = MinionEliteTemplates.TakeBunshinTypeFromDropDown(cbBunshinType);
            IRace RaceType = SummonMetadataList.TakeRaceFromDropDown(cbSummonType, cbsummonRank);
				
            if(tbCName.Text == "")
            {
                NPCTemplate.CreateItemAndPrintEx(NewCharBaseStats, MyClasses, MyLevels, "Output", 0, MyPRCount, 0, RaceType, CharType, BunshinType, cbStrRank.SelectedIndex, cbSpeedRank.SelectedIndex, cbSummonCategory.SelectedIndex);
            }
            else
            {
                NPCTemplate.CreateItemAndPrintEx(NewCharBaseStats, MyClasses, MyLevels, tbCName.Text, 0, MyPRCount, 0, RaceType, CharType, BunshinType, cbStrRank.SelectedIndex, cbSpeedRank.SelectedIndex, cbSummonCategory.SelectedIndex);
            }
            
            MessageBox.Show("Statblock Generated");

		}

        private int GetCurrentLevel()
        {
            int Count = 0;

            if (cbLevel.Enabled == true && cbLevel.SelectedIndex != 0)
            {
                Count += cbLevel.SelectedIndex;
            }

            return Count;
        }

		private void cbclassNM1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cbsummonRank.SelectedIndex != 0)
			{
                XMLClassList.PopulatePUCB(cbLevel);
                FillLabelsFromTemplate();
				cbLevel.Enabled = true;
			}
			else
			{
               cbLevel.Enabled = false;
			}
		}

		private void cbLevel1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		}

        private void cbTemplate1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 != cbSummonType.SelectedIndex)
            {
                SummonMetadataList.PopulateSummonRankCB(cbsummonRank, (string)cbSummonType.SelectedItem);
                cbsummonRank.Enabled = true;
            }
            else
            {
                cbsummonRank.Enabled = false;
            }
        }

        private void TemplateLabel_Click(object sender, EventArgs e)
        {

        }

        private void FillLabelsFromTemplate()
        {
            XMLRace race = SummonMetadataList.TakeRaceFromDropDown(cbSummonType, cbsummonRank);
            if (null != race.RacialStats &&
                (0 != race.RacialStats.StrScore || 0 != race.RacialStats.DexScore ||
                0 != race.RacialStats.ConScore || 0 != race.RacialStats.IntScore ||
                0 != race.RacialStats.WisScore || 0 != race.RacialStats.ChaScore))
            {
                //Update Strength
                if (false == string.IsNullOrEmpty(tbStr.Text) && false == string.IsNullOrEmpty(tbDex.Text) &&
                    false == string.IsNullOrEmpty(tbCon.Text) && false == string.IsNullOrEmpty(tbInt.Text) &&
                    false == string.IsNullOrEmpty(tbWis.Text) && false == string.IsNullOrEmpty(tbCha.Text))
                {
                    strTotalLabel.Text = (Convert.ToInt32(tbStr.Text) + race.RacialStats.StrScore).ToString();
                    dexTotalLabel.Text = (Convert.ToInt32(tbDex.Text) + race.RacialStats.DexScore).ToString();
                    conTotalLabel.Text = (Convert.ToInt32(tbCon.Text) + race.RacialStats.ConScore).ToString();
                    intTotalLabel.Text = (Convert.ToInt32(tbInt.Text) + race.RacialStats.IntScore).ToString();
                    wisTotalLabel.Text = (Convert.ToInt32(tbWis.Text) + race.RacialStats.WisScore).ToString();
                    chaTotalLabel.Text = (Convert.ToInt32(tbCha.Text) + race.RacialStats.ChaScore).ToString();
                }
                else
                {
                    strTotalLabel.Text = GeneratePlus(race.RacialStats.StrScore);
                    dexTotalLabel.Text = GeneratePlus(race.RacialStats.DexScore);
                    conTotalLabel.Text = GeneratePlus(race.RacialStats.ConScore);
                    intTotalLabel.Text = GeneratePlus(race.RacialStats.IntScore);
                    wisTotalLabel.Text = GeneratePlus(race.RacialStats.WisScore);
                    chaTotalLabel.Text = GeneratePlus(race.RacialStats.ChaScore);
                }
            }
            else
            {
                strTotalLabel.Text = "";
                dexTotalLabel.Text = "";
                conTotalLabel.Text = "";
                intTotalLabel.Text = "";
                wisTotalLabel.Text = "";
                chaTotalLabel.Text = "";
            }
        }

        private static string GeneratePlus(int number)
        {
            if (number >= 0)
            {
                return "+" + number.ToString();
            }
            else
            {
                return number.ToString();
            }
        }

        private void tbStatTextBox_TextChanged(object sender, EventArgs e)
        {
            FillLabelsFromTemplate();
        }
	}
}
