using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Nd20TemplateLib;
using ND20Bloodlines;

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
		private System.Windows.Forms.ComboBox cbclassNM1;
		private System.Windows.Forms.ComboBox cbLevel1;
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
		private System.Windows.Forms.ComboBox cbclassNM2;
		private System.Windows.Forms.ComboBox cbLevel2;
		private System.Windows.Forms.ComboBox cbclassNM3;
		private System.Windows.Forms.ComboBox cbclassNM4;
		private System.Windows.Forms.ComboBox cbclassNM5;
		private System.Windows.Forms.ComboBox cbLevel3;
		private System.Windows.Forms.ComboBox cbLevel4;
		private System.Windows.Forms.ComboBox cbLevel5;
		private System.Windows.Forms.Label PULabel;
		private System.Windows.Forms.ComboBox cbPowerUnits;
		private System.Windows.Forms.Label BLLabel;
		private System.Windows.Forms.ComboBox cbBloodlines;
        private ComboBox cbclassNM6;
        private ComboBox cbLevel6;
        private ComboBox cbclassNM7;
        private ComboBox cbLevel7;
        private Label CTLabel;
        private ComboBox cbCharType;
        private Label StrRLabel;
        private Label SpeedRLabel;
        private ComboBox cbStrRank;
        private ComboBox cbSpeedRank;
        private Label BunshinLabel;
        private ComboBox cbBunshinType;
        private Label TemplateLabel;
        private ComboBox cbTemplate1;
        private Label PRLabel;
        private ComboBox cbPowerRanks;
        private Label strTotalLabel;
        private Label dexTotalLabel;
        private Label conTotalLabel;
        private Label intTotalLabel;
        private Label wisTotalLabel;
        private Label chaTotalLabel;
        private Label statsLabel;
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
            this.cbclassNM1 = new System.Windows.Forms.ComboBox();
            this.cbLevel1 = new System.Windows.Forms.ComboBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.strLabel = new System.Windows.Forms.Label();
            this.dexLabel = new System.Windows.Forms.Label();
            this.conLabel = new System.Windows.Forms.Label();
            this.intLabel = new System.Windows.Forms.Label();
            this.wisLabel = new System.Windows.Forms.Label();
            this.chaLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.cbclassNM2 = new System.Windows.Forms.ComboBox();
            this.cbLevel2 = new System.Windows.Forms.ComboBox();
            this.cbclassNM3 = new System.Windows.Forms.ComboBox();
            this.cbclassNM4 = new System.Windows.Forms.ComboBox();
            this.cbclassNM5 = new System.Windows.Forms.ComboBox();
            this.cbLevel3 = new System.Windows.Forms.ComboBox();
            this.cbLevel4 = new System.Windows.Forms.ComboBox();
            this.cbLevel5 = new System.Windows.Forms.ComboBox();
            this.PULabel = new System.Windows.Forms.Label();
            this.cbPowerUnits = new System.Windows.Forms.ComboBox();
            this.BLLabel = new System.Windows.Forms.Label();
            this.cbBloodlines = new System.Windows.Forms.ComboBox();
            this.cbclassNM6 = new System.Windows.Forms.ComboBox();
            this.cbLevel6 = new System.Windows.Forms.ComboBox();
            this.cbclassNM7 = new System.Windows.Forms.ComboBox();
            this.cbLevel7 = new System.Windows.Forms.ComboBox();
            this.CTLabel = new System.Windows.Forms.Label();
            this.cbCharType = new System.Windows.Forms.ComboBox();
            this.StrRLabel = new System.Windows.Forms.Label();
            this.SpeedRLabel = new System.Windows.Forms.Label();
            this.cbStrRank = new System.Windows.Forms.ComboBox();
            this.cbSpeedRank = new System.Windows.Forms.ComboBox();
            this.BunshinLabel = new System.Windows.Forms.Label();
            this.cbBunshinType = new System.Windows.Forms.ComboBox();
            this.TemplateLabel = new System.Windows.Forms.Label();
            this.cbTemplate1 = new System.Windows.Forms.ComboBox();
            this.PRLabel = new System.Windows.Forms.Label();
            this.cbPowerRanks = new System.Windows.Forms.ComboBox();
            this.strTotalLabel = new System.Windows.Forms.Label();
            this.dexTotalLabel = new System.Windows.Forms.Label();
            this.conTotalLabel = new System.Windows.Forms.Label();
            this.intTotalLabel = new System.Windows.Forms.Label();
            this.wisTotalLabel = new System.Windows.Forms.Label();
            this.chaTotalLabel = new System.Windows.Forms.Label();
            this.tbCha = new Nd20StatblockGenerator.NumericTextBox();
            this.tbWis = new Nd20StatblockGenerator.NumericTextBox();
            this.tbInt = new Nd20StatblockGenerator.NumericTextBox();
            this.tbCon = new Nd20StatblockGenerator.NumericTextBox();
            this.tbDex = new Nd20StatblockGenerator.NumericTextBox();
            this.tbStr = new Nd20StatblockGenerator.NumericTextBox();
            this.statsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(8, 8);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(104, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name of Character:";
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
            this.ClassLabel.Size = new System.Drawing.Size(56, 24);
            this.ClassLabel.TabIndex = 2;
            this.ClassLabel.Text = "Classes:";
            // 
            // cbclassNM1
            // 
            this.cbclassNM1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbclassNM1.Location = new System.Drawing.Point(16, 114);
            this.cbclassNM1.Name = "cbclassNM1";
            this.cbclassNM1.Size = new System.Drawing.Size(120, 21);
            this.cbclassNM1.TabIndex = 3;
            this.cbclassNM1.SelectedIndexChanged += new System.EventHandler(this.cbclassNM1_SelectedIndexChanged);
            // 
            // cbLevel1
            // 
            this.cbLevel1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel1.Enabled = false;
            this.cbLevel1.Location = new System.Drawing.Point(152, 114);
            this.cbLevel1.Name = "cbLevel1";
            this.cbLevel1.Size = new System.Drawing.Size(48, 21);
            this.cbLevel1.TabIndex = 4;
            this.cbLevel1.SelectedIndexChanged += new System.EventHandler(this.cbLevel1_SelectedIndexChanged);
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
            this.GenerateButton.Location = new System.Drawing.Point(307, 400);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(64, 32);
            this.GenerateButton.TabIndex = 18;
            this.GenerateButton.Text = "Generate!";
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // cbclassNM2
            // 
            this.cbclassNM2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbclassNM2.Enabled = false;
            this.cbclassNM2.Location = new System.Drawing.Point(16, 146);
            this.cbclassNM2.Name = "cbclassNM2";
            this.cbclassNM2.Size = new System.Drawing.Size(120, 21);
            this.cbclassNM2.TabIndex = 25;
            this.cbclassNM2.SelectedIndexChanged += new System.EventHandler(this.cbclassNM2_SelectedIndexChanged);
            // 
            // cbLevel2
            // 
            this.cbLevel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel2.Enabled = false;
            this.cbLevel2.Location = new System.Drawing.Point(152, 146);
            this.cbLevel2.Name = "cbLevel2";
            this.cbLevel2.Size = new System.Drawing.Size(48, 21);
            this.cbLevel2.TabIndex = 26;
            this.cbLevel2.SelectedIndexChanged += new System.EventHandler(this.cbLevel2_SelectedIndexChanged);
            // 
            // cbclassNM3
            // 
            this.cbclassNM3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbclassNM3.Enabled = false;
            this.cbclassNM3.Location = new System.Drawing.Point(16, 178);
            this.cbclassNM3.Name = "cbclassNM3";
            this.cbclassNM3.Size = new System.Drawing.Size(120, 21);
            this.cbclassNM3.TabIndex = 27;
            this.cbclassNM3.SelectedIndexChanged += new System.EventHandler(this.cbclassNM3_SelectedIndexChanged);
            // 
            // cbclassNM4
            // 
            this.cbclassNM4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbclassNM4.Enabled = false;
            this.cbclassNM4.Location = new System.Drawing.Point(16, 210);
            this.cbclassNM4.Name = "cbclassNM4";
            this.cbclassNM4.Size = new System.Drawing.Size(120, 21);
            this.cbclassNM4.TabIndex = 28;
            this.cbclassNM4.SelectedIndexChanged += new System.EventHandler(this.cbclassNM4_SelectedIndexChanged);
            // 
            // cbclassNM5
            // 
            this.cbclassNM5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbclassNM5.Enabled = false;
            this.cbclassNM5.Location = new System.Drawing.Point(16, 242);
            this.cbclassNM5.Name = "cbclassNM5";
            this.cbclassNM5.Size = new System.Drawing.Size(120, 21);
            this.cbclassNM5.TabIndex = 29;
            this.cbclassNM5.SelectedIndexChanged += new System.EventHandler(this.cbclassNM5_SelectedIndexChanged);
            // 
            // cbLevel3
            // 
            this.cbLevel3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel3.Enabled = false;
            this.cbLevel3.Location = new System.Drawing.Point(152, 178);
            this.cbLevel3.Name = "cbLevel3";
            this.cbLevel3.Size = new System.Drawing.Size(48, 21);
            this.cbLevel3.TabIndex = 30;
            this.cbLevel3.SelectedIndexChanged += new System.EventHandler(this.cbLevel3_SelectedIndexChanged);
            // 
            // cbLevel4
            // 
            this.cbLevel4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel4.Enabled = false;
            this.cbLevel4.Location = new System.Drawing.Point(152, 210);
            this.cbLevel4.Name = "cbLevel4";
            this.cbLevel4.Size = new System.Drawing.Size(48, 21);
            this.cbLevel4.TabIndex = 31;
            this.cbLevel4.SelectedIndexChanged += new System.EventHandler(this.cbLevel4_SelectedIndexChanged);
            // 
            // cbLevel5
            // 
            this.cbLevel5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel5.Enabled = false;
            this.cbLevel5.Location = new System.Drawing.Point(152, 242);
            this.cbLevel5.Name = "cbLevel5";
            this.cbLevel5.Size = new System.Drawing.Size(48, 21);
            this.cbLevel5.TabIndex = 32;
            this.cbLevel5.SelectedIndexChanged += new System.EventHandler(this.cbLevel5_SelectedIndexChanged);
            // 
            // PULabel
            // 
            this.PULabel.Location = new System.Drawing.Point(33, 345);
            this.PULabel.Name = "PULabel";
            this.PULabel.Size = new System.Drawing.Size(72, 16);
            this.PULabel.TabIndex = 33;
            this.PULabel.Text = "Power Units:";
            // 
            // cbPowerUnits
            // 
            this.cbPowerUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPowerUnits.Location = new System.Drawing.Point(123, 345);
            this.cbPowerUnits.Name = "cbPowerUnits";
            this.cbPowerUnits.Size = new System.Drawing.Size(48, 21);
            this.cbPowerUnits.TabIndex = 34;
            // 
            // BLLabel
            // 
            this.BLLabel.Location = new System.Drawing.Point(35, 377);
            this.BLLabel.Name = "BLLabel";
            this.BLLabel.Size = new System.Drawing.Size(56, 23);
            this.BLLabel.TabIndex = 35;
            this.BLLabel.Text = "Bloodline:";
            // 
            // cbBloodlines
            // 
            this.cbBloodlines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBloodlines.Location = new System.Drawing.Point(123, 377);
            this.cbBloodlines.Name = "cbBloodlines";
            this.cbBloodlines.Size = new System.Drawing.Size(168, 21);
            this.cbBloodlines.TabIndex = 36;
            // 
            // cbclassNM6
            // 
            this.cbclassNM6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbclassNM6.Enabled = false;
            this.cbclassNM6.Location = new System.Drawing.Point(16, 269);
            this.cbclassNM6.Name = "cbclassNM6";
            this.cbclassNM6.Size = new System.Drawing.Size(120, 21);
            this.cbclassNM6.TabIndex = 37;
            this.cbclassNM6.SelectedIndexChanged += new System.EventHandler(this.cbclassNM6_SelectedIndexChanged);
            // 
            // cbLevel6
            // 
            this.cbLevel6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel6.Enabled = false;
            this.cbLevel6.Location = new System.Drawing.Point(152, 269);
            this.cbLevel6.Name = "cbLevel6";
            this.cbLevel6.Size = new System.Drawing.Size(48, 21);
            this.cbLevel6.TabIndex = 38;
            this.cbLevel6.SelectedIndexChanged += new System.EventHandler(this.cbLevel6_SelectedIndexChanged);
            // 
            // cbclassNM7
            // 
            this.cbclassNM7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbclassNM7.Enabled = false;
            this.cbclassNM7.Location = new System.Drawing.Point(16, 296);
            this.cbclassNM7.Name = "cbclassNM7";
            this.cbclassNM7.Size = new System.Drawing.Size(120, 21);
            this.cbclassNM7.TabIndex = 39;
            this.cbclassNM7.SelectedIndexChanged += new System.EventHandler(this.cbclassNM7_SelectedIndexChanged);
            // 
            // cbLevel7
            // 
            this.cbLevel7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel7.Enabled = false;
            this.cbLevel7.Location = new System.Drawing.Point(152, 296);
            this.cbLevel7.Name = "cbLevel7";
            this.cbLevel7.Size = new System.Drawing.Size(48, 21);
            this.cbLevel7.TabIndex = 40;
            this.cbLevel7.SelectedIndexChanged += new System.EventHandler(this.cbLevel7_SelectedIndexChanged);
            // 
            // CTLabel
            // 
            this.CTLabel.AutoSize = true;
            this.CTLabel.Location = new System.Drawing.Point(35, 410);
            this.CTLabel.Name = "CTLabel";
            this.CTLabel.Size = new System.Drawing.Size(83, 13);
            this.CTLabel.TabIndex = 41;
            this.CTLabel.Text = "Character Type:";
            // 
            // cbCharType
            // 
            this.cbCharType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCharType.Location = new System.Drawing.Point(123, 410);
            this.cbCharType.Name = "cbCharType";
            this.cbCharType.Size = new System.Drawing.Size(168, 21);
            this.cbCharType.TabIndex = 42;
            // 
            // StrRLabel
            // 
            this.StrRLabel.AutoSize = true;
            this.StrRLabel.Location = new System.Drawing.Point(35, 446);
            this.StrRLabel.Name = "StrRLabel";
            this.StrRLabel.Size = new System.Drawing.Size(79, 13);
            this.StrRLabel.TabIndex = 43;
            this.StrRLabel.Text = "Strength Rank:";
            // 
            // SpeedRLabel
            // 
            this.SpeedRLabel.AutoSize = true;
            this.SpeedRLabel.Location = new System.Drawing.Point(35, 475);
            this.SpeedRLabel.Name = "SpeedRLabel";
            this.SpeedRLabel.Size = new System.Drawing.Size(70, 13);
            this.SpeedRLabel.TabIndex = 44;
            this.SpeedRLabel.Text = "Speed Rank:";
            // 
            // cbStrRank
            // 
            this.cbStrRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStrRank.Location = new System.Drawing.Point(123, 446);
            this.cbStrRank.Name = "cbStrRank";
            this.cbStrRank.Size = new System.Drawing.Size(48, 21);
            this.cbStrRank.TabIndex = 45;
            // 
            // cbSpeedRank
            // 
            this.cbSpeedRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeedRank.Location = new System.Drawing.Point(123, 475);
            this.cbSpeedRank.Name = "cbSpeedRank";
            this.cbSpeedRank.Size = new System.Drawing.Size(48, 21);
            this.cbSpeedRank.TabIndex = 46;
            // 
            // BunshinLabel
            // 
            this.BunshinLabel.AutoSize = true;
            this.BunshinLabel.Location = new System.Drawing.Point(35, 515);
            this.BunshinLabel.Name = "BunshinLabel";
            this.BunshinLabel.Size = new System.Drawing.Size(75, 13);
            this.BunshinLabel.TabIndex = 47;
            this.BunshinLabel.Text = "Bunshin Type:";
            // 
            // cbBunshinType
            // 
            this.cbBunshinType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBunshinType.Location = new System.Drawing.Point(123, 507);
            this.cbBunshinType.Name = "cbBunshinType";
            this.cbBunshinType.Size = new System.Drawing.Size(168, 21);
            this.cbBunshinType.TabIndex = 48;
            // 
            // TemplateLabel
            // 
            this.TemplateLabel.Location = new System.Drawing.Point(24, 50);
            this.TemplateLabel.Name = "TemplateLabel";
            this.TemplateLabel.Size = new System.Drawing.Size(72, 16);
            this.TemplateLabel.TabIndex = 49;
            this.TemplateLabel.Text = "Race:";
            this.TemplateLabel.Click += new System.EventHandler(this.TemplateLabel_Click);
            // 
            // cbTemplate1
            // 
            this.cbTemplate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTemplate1.Location = new System.Drawing.Point(112, 45);
            this.cbTemplate1.Name = "cbTemplate1";
            this.cbTemplate1.Size = new System.Drawing.Size(168, 21);
            this.cbTemplate1.TabIndex = 50;
            this.cbTemplate1.SelectedIndexChanged += new System.EventHandler(this.cbTemplate1_SelectedIndexChanged);
            // 
            // PRLabel
            // 
            this.PRLabel.Location = new System.Drawing.Point(33, 548);
            this.PRLabel.Name = "PRLabel";
            this.PRLabel.Size = new System.Drawing.Size(84, 16);
            this.PRLabel.TabIndex = 51;
            this.PRLabel.Text = "Power Ranks:";
            // 
            // cbPowerRanks
            // 
            this.cbPowerRanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPowerRanks.Location = new System.Drawing.Point(123, 543);
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
            // tbCha
            // 
            this.tbCha.Location = new System.Drawing.Point(344, 184);
            this.tbCha.Name = "tbCha";
            this.tbCha.Size = new System.Drawing.Size(32, 20);
            this.tbCha.TabIndex = 24;
            this.tbCha.TextChanged += new System.EventHandler(this.tbStatTextBox_TextChanged);
            // 
            // tbWis
            // 
            this.tbWis.Location = new System.Drawing.Point(344, 160);
            this.tbWis.Name = "tbWis";
            this.tbWis.Size = new System.Drawing.Size(32, 20);
            this.tbWis.TabIndex = 23;
            this.tbWis.TextChanged += new System.EventHandler(this.tbStatTextBox_TextChanged);
            // 
            // tbInt
            // 
            this.tbInt.Location = new System.Drawing.Point(344, 136);
            this.tbInt.Name = "tbInt";
            this.tbInt.Size = new System.Drawing.Size(32, 20);
            this.tbInt.TabIndex = 22;
            this.tbInt.TextChanged += new System.EventHandler(this.tbStatTextBox_TextChanged);
            // 
            // tbCon
            // 
            this.tbCon.Location = new System.Drawing.Point(344, 112);
            this.tbCon.Name = "tbCon";
            this.tbCon.Size = new System.Drawing.Size(32, 20);
            this.tbCon.TabIndex = 21;
            this.tbCon.TextChanged += new System.EventHandler(this.tbStatTextBox_TextChanged);
            // 
            // tbDex
            // 
            this.tbDex.Location = new System.Drawing.Point(344, 88);
            this.tbDex.Name = "tbDex";
            this.tbDex.Size = new System.Drawing.Size(32, 20);
            this.tbDex.TabIndex = 20;
            this.tbDex.TextChanged += new System.EventHandler(this.tbStatTextBox_TextChanged);
            // 
            // tbStr
            // 
            this.tbStr.Location = new System.Drawing.Point(344, 64);
            this.tbStr.Name = "tbStr";
            this.tbStr.Size = new System.Drawing.Size(32, 20);
            this.tbStr.TabIndex = 19;
            this.tbStr.TextChanged += new System.EventHandler(this.tbStatTextBox_TextChanged);
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
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(452, 583);
            this.Controls.Add(this.statsLabel);
            this.Controls.Add(this.chaTotalLabel);
            this.Controls.Add(this.wisTotalLabel);
            this.Controls.Add(this.intTotalLabel);
            this.Controls.Add(this.conTotalLabel);
            this.Controls.Add(this.dexTotalLabel);
            this.Controls.Add(this.strTotalLabel);
            this.Controls.Add(this.cbPowerRanks);
            this.Controls.Add(this.PRLabel);
            this.Controls.Add(this.cbTemplate1);
            this.Controls.Add(this.TemplateLabel);
            this.Controls.Add(this.cbBunshinType);
            this.Controls.Add(this.BunshinLabel);
            this.Controls.Add(this.cbSpeedRank);
            this.Controls.Add(this.cbStrRank);
            this.Controls.Add(this.SpeedRLabel);
            this.Controls.Add(this.StrRLabel);
            this.Controls.Add(this.cbCharType);
            this.Controls.Add(this.CTLabel);
            this.Controls.Add(this.cbLevel7);
            this.Controls.Add(this.cbclassNM7);
            this.Controls.Add(this.cbLevel6);
            this.Controls.Add(this.cbclassNM6);
            this.Controls.Add(this.cbBloodlines);
            this.Controls.Add(this.BLLabel);
            this.Controls.Add(this.cbPowerUnits);
            this.Controls.Add(this.PULabel);
            this.Controls.Add(this.cbLevel5);
            this.Controls.Add(this.cbLevel4);
            this.Controls.Add(this.cbLevel3);
            this.Controls.Add(this.cbclassNM5);
            this.Controls.Add(this.cbclassNM4);
            this.Controls.Add(this.cbclassNM3);
            this.Controls.Add(this.cbLevel2);
            this.Controls.Add(this.cbclassNM2);
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
            this.Controls.Add(this.cbLevel1);
            this.Controls.Add(this.cbclassNM1);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "Naruto D20 Statblock Generator v3.2";
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
            //Load XML
            try
            {
                XMLClassList.Initialize(".\\Classes.xml");
                XMLClassList.PopulateClassCB(cbclassNM1, 0);
                XMLClassList.PopulatePUCB(cbPowerUnits);
                XMLClassList.PopulatePUCB(cbPowerRanks);
            }
            catch (Exception Exp)
            {
                MessageBox.Show("Error in the Classes XML Detected!  Aborting launch of Statblock Generator. If this problem persists, please redownload the affected component.");
                Environment.Exit(1);
            }

            try
            {
                BloodlineRetrievalLibrary.FillBloodlineDropdown(cbBloodlines);
            }
            catch (Exception Exp)
            {
                MessageBox.Show("Error in the Bloodlines XML / DLL Detected!  Aborting launch of Statblock Generator. If this problem persists, please redownload the affected component.");
                Environment.Exit(1);
            }

            try
            {
                MinionEliteTemplates.FillRaceDropdown(cbTemplate1);
            }
            catch (Exception)
            {
                MessageBox.Show("Error in the Races XML / DLL Detected!  Aborting launch of Statblock Generator. If this problem persists, please redownload the affected component.");
                Environment.Exit(1);
            }

            MinionEliteTemplates.FillMinionEliteDropDown(cbCharType);
            MinionEliteTemplates.FillBunshinDropDown(cbBunshinType);
            XMLClassList.PopulateSpeedStrRankCB(cbStrRank);
            XMLClassList.PopulateSpeedStrRankCB(cbSpeedRank);          
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

            string[] MyClasses = new string[7];
            int[] MyLevels = new int[7];

			//Fill In Class and Levels from Form
			if(cbclassNM1.Enabled == true && cbclassNM1.SelectedIndex > 0 && cbLevel1.SelectedIndex > 0)
			{
				MyClasses[0] = cbclassNM1.Text;
				MyLevels[0] = cbLevel1.SelectedIndex;
			}
			else
			{
                MessageBox.Show("There must at least one class declared.");
                return;
			}

			if(cbclassNM2.Enabled == true && cbclassNM2.SelectedIndex > 0 && cbLevel2.SelectedIndex > 0)
			{
                MyClasses[1] = cbclassNM2.Text;
				MyLevels[1] = cbLevel2.SelectedIndex;
			}
			else
			{
                MyClasses[1] = null;
                MyLevels[1] = 0;
			}

			if(cbclassNM3.Enabled == true && cbclassNM3.SelectedIndex > 0 && cbLevel3.SelectedIndex > 0)
			{
                MyClasses[2] = cbclassNM3.Text;
				MyLevels[2] = cbLevel3.SelectedIndex;
			}
			else
			{
                MyClasses[2] = null;
                MyLevels[2] = 0;
			}

			if(cbclassNM4.Enabled == true && cbclassNM4.SelectedIndex > 0 && cbLevel4.SelectedIndex > 0)
			{
                MyClasses[3] = cbclassNM4.Text;
				MyLevels[3] = cbLevel4.SelectedIndex;
			}
			else
			{
                MyClasses[3] = null;
                MyLevels[3] = 0;
			}

			if(cbclassNM5.Enabled == true && cbclassNM5.SelectedIndex > 0 && cbLevel5.SelectedIndex > 0)
			{
                MyClasses[4] = cbclassNM5.Text;
				MyLevels[4] = cbLevel5.SelectedIndex;
			}
			else
			{
                MyClasses[4] = null;
                MyLevels[4] = 0;
			}

            if (cbclassNM6.Enabled == true && cbclassNM6.SelectedIndex > 0 && cbLevel6.SelectedIndex > 0)
            {
                MyClasses[5] = cbclassNM6.Text;
                MyLevels[5] = cbLevel6.SelectedIndex;
            }
            else
            {
                MyClasses[5] = null;
                MyLevels[5] = 0;
            }

            if (cbclassNM7.Enabled == true && cbclassNM7.SelectedIndex > 0 && cbLevel7.SelectedIndex > 0)
            {
                MyClasses[6] = cbclassNM7.Text;
                MyLevels[6] = cbLevel7.SelectedIndex;
            }
            else
            {
                MyClasses[6] = null;
                MyLevels[6] = 0;
            }

            
            int MyPUCount = cbPowerUnits.SelectedIndex;
            int MyPRCount = cbPowerRanks.SelectedIndex;
            int BloodlineChosen = cbBloodlines.SelectedIndex;

            ICharacterType CharType = MinionEliteTemplates.TakeCharacterTypeFromDropDown(cbCharType);
            ICharacterType BunshinType = MinionEliteTemplates.TakeBunshinTypeFromDropDown(cbBunshinType);
            IRace RaceType = MinionEliteTemplates.TakeRaceFromDropDown(cbTemplate1);
				
            if(tbCName.Text == "")
            {
                NPCTemplate.CreateItemAndPrintEx(NewCharBaseStats, MyClasses, MyLevels, "Output", MyPUCount, MyPRCount, BloodlineChosen, RaceType, CharType, BunshinType, cbStrRank.SelectedIndex, cbSpeedRank.SelectedIndex);
            }
            else
            {
                NPCTemplate.CreateItemAndPrintEx(NewCharBaseStats, MyClasses, MyLevels, tbCName.Text, MyPUCount, MyPRCount, BloodlineChosen, RaceType, CharType, BunshinType, cbStrRank.SelectedIndex, cbSpeedRank.SelectedIndex);
            }
            
            MessageBox.Show("Statblock Generated");

		}

        private int GetCurrentLevel()
        {
            int Count = 0;

            if (cbLevel1.Enabled == true && cbLevel1.SelectedIndex != 0)
            {
                Count += cbLevel1.SelectedIndex;
            }

            if (cbLevel2.Enabled == true && cbLevel2.SelectedIndex != 0)
            {
                Count += cbLevel2.SelectedIndex;
            }

            if (cbLevel3.Enabled == true && cbLevel3.SelectedIndex != 0)
            {
                Count += cbLevel3.SelectedIndex;
            }

            if (cbLevel4.Enabled == true && cbLevel4.SelectedIndex != 0)
            {
                Count += cbLevel4.SelectedIndex;
            }

            if (cbLevel5.Enabled == true && cbLevel5.SelectedIndex != 0)
            {
                Count += cbLevel5.SelectedIndex;
            }

            return Count;
        }

		private void cbclassNM1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cbclassNM1.SelectedIndex != 0)
			{
				XMLClassList.PopulateLevelCB(cbLevel1, cbclassNM1.Text);
				cbLevel1.Enabled = true;
			}
			else
			{
               cbLevel1.Enabled = false;
			}
		}

		private void cbLevel1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cbLevel1.SelectedIndex != 0)
			{
                XMLClassList.PopulateClassCB(cbclassNM2, GetCurrentLevel());
				cbclassNM2.Enabled = true;
			}
			else
			{
				cbclassNM2.Enabled = false;
				cbLevel2.Enabled = false;
				cbclassNM3.Enabled = false;
				cbLevel3.Enabled = false;
				cbclassNM4.Enabled = false;
				cbLevel4.Enabled = false;
				cbclassNM5.Enabled = false;
				cbLevel5.Enabled = false;
			}
		}

		private void cbclassNM2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cbclassNM2.SelectedIndex != 0)
			{
                XMLClassList.PopulateLevelCB(cbLevel2, cbclassNM2.Text);
				cbLevel2.Enabled = true;
			}
			else
			{
				cbLevel2.Enabled = false;
				cbclassNM3.Enabled = false;
				cbLevel3.Enabled = false;
				cbclassNM4.Enabled = false;
				cbLevel4.Enabled = false;
				cbclassNM5.Enabled = false;
				cbLevel5.Enabled = false;
			}
		}

		private void cbLevel2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cbLevel2.SelectedIndex != 0)
			{
                XMLClassList.PopulateClassCB(cbclassNM3, GetCurrentLevel());
				cbclassNM3.Enabled = true;
			}
			else
			{
				cbclassNM3.Enabled = false;
				cbLevel3.Enabled = false;
				cbclassNM4.Enabled = false;
				cbLevel4.Enabled = false;
				cbclassNM5.Enabled = false;
				cbLevel5.Enabled = false;
			}
		}

		private void cbclassNM3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cbclassNM3.SelectedIndex != 0)
			{
                XMLClassList.PopulateLevelCB(cbLevel3, cbclassNM3.Text);
				cbLevel3.Enabled = true;
			}
			else
			{
				cbLevel3.Enabled = false;
				cbclassNM4.Enabled = false;
				cbLevel4.Enabled = false;
				cbclassNM5.Enabled = false;
				cbLevel5.Enabled = false;
			}
		}

		private void cbLevel3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cbLevel3.SelectedIndex != 0)
			{
                XMLClassList.PopulateClassCB(cbclassNM4, GetCurrentLevel());
				cbclassNM4.Enabled = true;
			}
			else
			{
				cbclassNM4.Enabled = false;
				cbLevel4.Enabled = false;
				cbclassNM5.Enabled = false;
				cbLevel5.Enabled = false;
			}

		}

		private void cbclassNM4_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cbclassNM4.SelectedIndex != 0)
			{
                XMLClassList.PopulateLevelCB(cbLevel4, cbclassNM4.Text);
				cbLevel4.Enabled = true;
			}
			else
			{
				cbLevel4.Enabled = false;
				cbclassNM5.Enabled = false;
				cbLevel5.Enabled = false;
			}
		}

		private void cbLevel4_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cbLevel4.SelectedIndex != 0)
			{
                XMLClassList.PopulateClassCB(cbclassNM5, GetCurrentLevel());
				cbclassNM5.Enabled = true;
			}
			else
			{
				cbclassNM5.Enabled = false;
				cbLevel5.Enabled = false;
			}
		}

		private void cbclassNM5_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(cbclassNM5.SelectedIndex != 0)
			{
                XMLClassList.PopulateLevelCB(cbLevel5, cbclassNM5.Text);
				cbLevel5.Enabled = true;
			}
			else
			{
				cbLevel5.Enabled = false;
			}
		}

        private void cbLevel5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLevel5.SelectedIndex != 0)
            {
                XMLClassList.PopulateClassCB(cbclassNM6, GetCurrentLevel());
                cbclassNM6.Enabled = true;
            }
            else
            {
                cbclassNM6.Enabled = false;
                cbLevel6.Enabled = false;
            }
        }

        private void cbclassNM6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbclassNM6.SelectedIndex != 0)
            {
                XMLClassList.PopulateLevelCB(cbLevel6, cbclassNM6.Text);
                cbLevel6.Enabled = true;
            }
            else
            {
                cbLevel6.Enabled = false;
            }
        }

        private void cbLevel6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLevel6.SelectedIndex != 0)
            {
                XMLClassList.PopulateClassCB(cbclassNM7, GetCurrentLevel());
                cbclassNM7.Enabled = true;
            }
            else
            {
                cbclassNM7.Enabled = false;
                cbLevel7.Enabled = false;
            }
        }

        private void cbclassNM7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbclassNM7.SelectedIndex != 0)
            {
                XMLClassList.PopulateLevelCB(cbLevel7, cbclassNM7.Text);
                cbLevel7.Enabled = true;
            }
            else
            {
                cbLevel7.Enabled = false;
            }
        }

        private void cbLevel7_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Do nothing
        }

        private void cbTemplate1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MinionEliteTemplates.TakeRaceFromDropDown(cbTemplate1).PossessesRacialHD() == true)
            {
                XMLClassList.PopulateClassCB(cbclassNM1, 1);
            }
            else
            {
                XMLClassList.PopulateClassCB(cbclassNM1, 0);
            }
            FillLabelsFromTemplate();
        }

        private void TemplateLabel_Click(object sender, EventArgs e)
        {

        }

        private void FillLabelsFromTemplate()
        {
            XMLRace race = MinionEliteTemplates.TakeRaceFromDropDown(cbTemplate1);
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
