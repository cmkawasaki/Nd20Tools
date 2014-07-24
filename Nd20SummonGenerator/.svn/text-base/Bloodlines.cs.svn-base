using System;
using System.Windows.Forms;

namespace Nd20StatblockGenerator
{
	/// <summary>
	/// Summary description for Bloodlines.
	/// </summary>
	/// 
		enum BloodlineEnum {NONE, BYAKUGAN, CHILDWILD, DAIRIKI, DOUKAGAN, FORTIFY, GUMOSHIN, HIRAISHIN, 
			HYOUMA, KAMITORA, KATSUGAN, KIKAI, KYUUSHOU, REIKYOU, SHARINGAN_MINOR, SHARINGAN_MAJOR, SHINSO,
			SHIKOTSU_MINOR, SHIKOTSU_MED, SHIKOTSU_MAJOR, SATORI_MED, SATORI_MAJOR, DEMON};

	public class Bloodlines
	{
	
		public static string[] BloodNames = new string[23] {"No Bloodline", "Byakugan", "Child of the Wild", "Dairiki", 
				"Doukagan", "Fortify", "Gumoshin", "Hiraishin", "Hyouma", "Kamitora", "Katsugan", "Kikai Host", 
				"Kyuushou Kousei", "Reikyou", "Sharingan Eye, Minor", "Sharingan Eye, Intermediate", "Shinso",
				"Shikotsu Myaku, Minor", "Shikotsu Myaku, Intermediate", "Shikotsu Myaku, Major", "Satori, Intermediate", "Satori, Major", "Demon"};
		public Bloodlines()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static void PopulateBloodlineCB(ComboBox lComboBox)
		{
			lComboBox.Items.Clear();
			lComboBox.Items.Insert((int)BloodlineEnum.NONE, BloodNames[(int)BloodlineEnum.NONE]);
			lComboBox.Items.Insert((int)BloodlineEnum.BYAKUGAN, BloodNames[(int)BloodlineEnum.BYAKUGAN]);
			lComboBox.Items.Insert((int)BloodlineEnum.CHILDWILD, BloodNames[(int)BloodlineEnum.CHILDWILD]);
			lComboBox.Items.Insert((int)BloodlineEnum.DAIRIKI, BloodNames[(int)BloodlineEnum.DAIRIKI]);
			lComboBox.Items.Insert((int)BloodlineEnum.DOUKAGAN, BloodNames[(int)BloodlineEnum.DOUKAGAN]);
			lComboBox.Items.Insert((int)BloodlineEnum.FORTIFY, BloodNames[(int)BloodlineEnum.FORTIFY]);
			lComboBox.Items.Insert((int)BloodlineEnum.GUMOSHIN, BloodNames[(int)BloodlineEnum.GUMOSHIN]);
			lComboBox.Items.Insert((int)BloodlineEnum.HIRAISHIN, BloodNames[(int)BloodlineEnum.HIRAISHIN]);
			lComboBox.Items.Insert((int)BloodlineEnum.HYOUMA, BloodNames[(int)BloodlineEnum.HYOUMA]);
			lComboBox.Items.Insert((int)BloodlineEnum.KAMITORA, BloodNames[(int)BloodlineEnum.KAMITORA]);
			lComboBox.Items.Insert((int)BloodlineEnum.KATSUGAN, BloodNames[(int)BloodlineEnum.KATSUGAN]);
			lComboBox.Items.Insert((int)BloodlineEnum.KIKAI, BloodNames[(int)BloodlineEnum.KIKAI]);
			lComboBox.Items.Insert((int)BloodlineEnum.KYUUSHOU, BloodNames[(int)BloodlineEnum.KYUUSHOU]);
			lComboBox.Items.Insert((int)BloodlineEnum.REIKYOU, BloodNames[(int)BloodlineEnum.REIKYOU]);
			lComboBox.Items.Insert((int)BloodlineEnum.SHARINGAN_MINOR, BloodNames[(int)BloodlineEnum.SHARINGAN_MINOR]);
			lComboBox.Items.Insert((int)BloodlineEnum.SHARINGAN_MAJOR, BloodNames[(int)BloodlineEnum.SHARINGAN_MAJOR]);
			lComboBox.Items.Insert((int)BloodlineEnum.SHINSO, BloodNames[(int)BloodlineEnum.SHINSO]);
			lComboBox.Items.Insert((int)BloodlineEnum.SHIKOTSU_MINOR, BloodNames[(int)BloodlineEnum.SHIKOTSU_MINOR]);
			lComboBox.Items.Insert((int)BloodlineEnum.SHIKOTSU_MED, BloodNames[(int)BloodlineEnum.SHIKOTSU_MED]);
			lComboBox.Items.Insert((int)BloodlineEnum.SHIKOTSU_MAJOR, BloodNames[(int)BloodlineEnum.SHIKOTSU_MAJOR]);
			lComboBox.Items.Insert((int)BloodlineEnum.SATORI_MED, BloodNames[(int)BloodlineEnum.SATORI_MED]);
			lComboBox.Items.Insert((int)BloodlineEnum.SATORI_MAJOR, BloodNames[(int)BloodlineEnum.SATORI_MAJOR]);
            lComboBox.Items.Insert((int)BloodlineEnum.DEMON, BloodNames[(int)BloodlineEnum.DEMON]);
			lComboBox.SelectedIndex = 0;
		}

		public static string GetFeatsText(int Level, int ENUM)
		{
			string returnString = "";
			int CharFeats = 0;

			if(ENUM == (int)BloodlineEnum.NONE)
			{
				CharFeats = (Level/3)+2;
				return " (" + CharFeats + " feats)";
			}
			else
			{
				CharFeats = (Level/3)+1;
				returnString += " Advanced Bloodline (" + BloodNames[ENUM] + ")";
			}

			if(ENUM == (int)BloodlineEnum.GUMOSHIN && Level >= 7)
			{
				returnString += ", Blood Pact (Spider)";
			}

			if(ENUM == (int)BloodlineEnum.HYOUMA)
			{
				returnString += ", Hyouton";
			}

			if(ENUM == (int)BloodlineEnum.REIKYOU)
			{
				returnString += ", Chakra Restoration";

				if(Level >= 9)
					returnString += ", Improved Chakra Pool";
				if(Level >= 17)
					returnString += " * 2";
			}

			returnString += ", " + CharFeats + " more feats";
			return returnString;
		}

		public static int GetBloodlineECL(int ENUM, int Level)
		{
			//Major Bloodline
			if(ENUM == (int)BloodlineEnum.KAMITORA ||
				ENUM == (int)BloodlineEnum.SHINSO ||
				ENUM == (int)BloodlineEnum.SHIKOTSU_MAJOR ||
				ENUM == (int)BloodlineEnum.SATORI_MAJOR)
			{
				if(Level >= 6 && Level <= 10)
					return 1;
				else if(Level >= 11 && Level <= 15)
					return 2;
				else if(Level >= 16)
					return 3;
				else
					return 0;

			}

			//Intermediate Bloodline
			if(ENUM == (int)BloodlineEnum.BYAKUGAN ||
				ENUM == (int)BloodlineEnum.HYOUMA ||
				ENUM == (int)BloodlineEnum.KYUUSHOU ||
				ENUM == (int)BloodlineEnum.REIKYOU ||
				ENUM == (int)BloodlineEnum.SHARINGAN_MAJOR ||
				ENUM == (int)BloodlineEnum.SHIKOTSU_MED ||
				ENUM == (int)BloodlineEnum.SATORI_MED)
			{
				if(Level >= 6 && Level <= 12)
					return 1;
				else if(Level >= 13)
					return 2;
				else
					return 0;
			}

			//Minor Bloodline
			if(ENUM == (int)BloodlineEnum.CHILDWILD ||
				ENUM == (int)BloodlineEnum.DAIRIKI ||
				ENUM == (int)BloodlineEnum.DOUKAGAN ||
				ENUM == (int)BloodlineEnum.FORTIFY ||
				ENUM == (int)BloodlineEnum.GUMOSHIN ||
				ENUM == (int)BloodlineEnum.HIRAISHIN ||
				ENUM == (int)BloodlineEnum.KATSUGAN||
				ENUM == (int)BloodlineEnum.KIKAI ||
				ENUM == (int)BloodlineEnum.SHARINGAN_MINOR ||
				ENUM == (int)BloodlineEnum.SHIKOTSU_MINOR)
			{
				if(Level >= 7)
					return 1;
				else
					return 0;
			}

			//None
			return 0;
		}
		public static string GetTalentStringByChoice(int ENUM, int Level)
		{
			if(ENUM == (int)BloodlineEnum.BYAKUGAN)
				return GetByakuganSQ(Level);
			else if(ENUM == (int)BloodlineEnum.CHILDWILD)
				return GetChildOfTheWildSQ(Level);
			else if(ENUM == (int)BloodlineEnum.DAIRIKI)
				return GetDairikiSQ(Level);
			else if(ENUM == (int)BloodlineEnum.DOUKAGAN)
				return GetDoukaganSQ(Level);
			else if(ENUM == (int)BloodlineEnum.FORTIFY)
				return GetFortifySQ(Level);
			else if(ENUM == (int)BloodlineEnum.GUMOSHIN)
				return GetGumoshinSQ(Level);
			else if(ENUM == (int)BloodlineEnum.HIRAISHIN)
				return GetHiraishinSQ(Level);
			else if(ENUM == (int)BloodlineEnum.HYOUMA)
				return GetHyoumaSQ(Level);
			else if(ENUM == (int)BloodlineEnum.KAMITORA)
				return GetKamitoraSQ(Level);
			else if(ENUM == (int)BloodlineEnum.KATSUGAN)
				return GetKatsuganSQ(Level);
			else if(ENUM == (int)BloodlineEnum.KIKAI)
				return GetKikaiSQ(Level);
			else if(ENUM == (int)BloodlineEnum.KYUUSHOU)
				return GetKyuushouSQ(Level);
			else if(ENUM == (int)BloodlineEnum.REIKYOU)
				return GetReikyouSQ(Level);
			else if(ENUM == (int)BloodlineEnum.SHARINGAN_MINOR)
				return GetSharinganMinorSQ(Level);
			else if(ENUM == (int)BloodlineEnum.SHARINGAN_MAJOR)
				return GetSharinganMajorSQ(Level);
			else if(ENUM == (int)BloodlineEnum.SHINSO)
				return GetShinsoSQ(Level);
			else if(ENUM == (int)BloodlineEnum.SHIKOTSU_MINOR)
				return GetShikotsuMinorSQ(Level);
			else if(ENUM == (int)BloodlineEnum.SHIKOTSU_MED)
				return GetShikotsuMedSQ(Level);
			else if(ENUM == (int)BloodlineEnum.SHIKOTSU_MAJOR)
				return GetShikotsuMajorSQ(Level);
			else if(ENUM == (int)BloodlineEnum.SATORI_MED)
				return GetSatoriMedSQ(Level);
			else if(ENUM == (int)BloodlineEnum.SATORI_MAJOR)
				return GetSatoriMajorSQ(Level);
            else if (ENUM == (int)BloodlineEnum.DEMON)
                return GetDemonSQ(Level);
			else
				return "";
		}
		public static string GetByakuganSQ(int Level)
		{
			string returnString = "";
			int ByakuEye = 0;
			int CombInsight = 0;
			int KeenSight = 0;

			//Byakugan bonus
			if(Level < 5)
				ByakuEye = 1;
			else if (Level < 10)
				ByakuEye = 2;
			else if (Level < 14)
				ByakuEye = 3;
			else if (Level < 19)
				ByakuEye = 4;
			else
				ByakuEye = 5;

			//Combat Insight Bonus
			if(Level < 9)
				CombInsight = 1;
			else if (Level < 13)
				CombInsight = 2;
			else if (Level < 18)
				CombInsight = 3;
			else
				CombInsight = 4;

			//Keen Sight Bonus
			if(Level < 12)
				KeenSight = 2;
			else if (Level < 16)
				KeenSight = 4;
			else
				KeenSight = 6;

			//Assemble String
			returnString += "byakugan +" + ByakuEye;
			if(Level >= 3)
				returnString += ", keen sight +" + KeenSight;
			if(Level >= 4)
				returnString += ", combat insight +" + CombInsight;
			if(Level >= 7)
				returnString += ", telescopic eye";
			if(Level >= 8)
				returnString += ", tenketsu sealing";

			return returnString;
		}
		public static string GetChildOfTheWildSQ(int Level)
		{
			string returnString = "";

			string ScentLevel;
			int Aware;

			if(Level >= 15)
				Aware = 4;
			else
				Aware = 2;

			if(Level >= 20)
				ScentLevel = "greater";
			else if(Level >= 12)
				ScentLevel = "lesser";
			else
				ScentLevel = "least";

			if(Level < 3)
				return "None";
			if(Level >= 3)
				returnString += "scent(" + ScentLevel + ")";
			if(Level >= 6)
				returnString += ", aware +" + Aware;

			return returnString;
		}
		public static string GetDairikiSQ(int Level)
		{
			string returnString = "";

			int Dairiki;
			int EarthResist;
			int PowerOEarth;

			if(Level >= 10)
				Dairiki = 2;
			else
				Dairiki = 1;

			if(Level >= 15)
				EarthResist = 10;
			else
				EarthResist = 5;

			if(Level >= 20)
				PowerOEarth = 5;
			else if(Level >= 16)
				PowerOEarth = 4;
			else if(Level >= 12)
				PowerOEarth = 3;
			else if(Level >= 9)
				PowerOEarth = 2;
			else
				PowerOEarth = 1;

			if(Level < 3)
				return "None";
			if(Level >= 3)
				returnString += "dairiki +" + Dairiki;
			if(Level >= 4)
				returnString += ", earth resistance " + EarthResist;
			if(Level >= 6)
				returnString += ", power of the earth +" + PowerOEarth;

			return returnString;
		}
		public static string GetDoukaganSQ(int Level)
		{
			string returnString = "";
			int Doukagan;
			int HighSight;

			if(Level >= 17)
				Doukagan = 3;
			else if(Level >= 11)
				Doukagan = 2;
			else
				Doukagan = 1;

			if(Level >= 20)
				HighSight = 3;
			else if(Level >= 14)
				HighSight = 2;
			else
				HighSight = 1;

			if(Level < 2)
				return "None";
			if(Level >= 2)
				returnString += "doukagan +" + Doukagan;
			if(Level >= 5)
				returnString += ", high speed sight " + HighSight;
			if(Level >= 8)
				returnString += ", osmosis";

			return returnString;
		}
		public static string GetFortifySQ(int Level)
		{
			string returnString = "";
			int LesserSS;
			int StoneS;
			int GreaterSS;
			int FortifyI;
			int FortifyII;

			if(Level >= 7)
				FortifyI = 5;
			else if(Level >= 4)
				FortifyI = 3;
			else
				FortifyI = 2;

			if(Level >= 5)
				LesserSS = 2;
			else
				LesserSS = 1;

			if(Level >= 11)
				StoneS = 4;
			else
				StoneS = 3;

			if(Level >= 16)
				FortifyII = 8;
			else if(Level >= 13)
				FortifyII = 7;
			else
				FortifyII = 5;

			if(Level >= 17)
				GreaterSS = 6;
			else
				GreaterSS = 5;

			returnString += "lesser stone skin +" + LesserSS;

			if(Level >= 2)
				returnString += ", fortify I (" + FortifyI + "/chakra)";
			if(Level >= 8)
				returnString += ", stone skin +" + StoneS;
			if(Level >= 10)
				returnString += ", fortify II (" + FortifyII + "/chakra)";
			if(Level >= 14)
				returnString += ", greater stone skin +" + GreaterSS;
			if(Level >= 19)
				returnString += ", fortify III (10/chakra)";
			if(Level >= 20)
				returnString += ", earth frenzy";

			return returnString;
		}
		public static string GetGumoshinSQ(int Level)
		{
			string returnString = "";
			int SClimb;
			int SFortSave;
			int SAffinity;

			if(Level >= 19)
				SClimb = 3;
			else if(Level >= 11)
				SClimb = 2;
			else
				SClimb = 1;

			if(Level >= 17)
				SFortSave = 3;
			else if(Level >= 13)
				SFortSave = 2;
			else
				SFortSave = 1;

			if(Level >= 15)
				SAffinity = 4;
			else
				SAffinity = 2;

			returnString += "spider silk";

			if(Level >= 3)
				returnString += ", spider climb " + SClimb + "/day";
			if(Level >= 5)
				returnString += ", spider affinity +" + SAffinity;
			if(Level >= 9)
				returnString += ", +" + SFortSave + " bonus to fortitude vs. spider poison";


			return returnString;
		}
		public static string GetHiraishinSQ(int Level)
		{
			string returnString = "";
			int Hiraishin = ((int)((Level-2)/6))+1;
			int SlowFall;

			if(Level >= 17)
				SlowFall = 50;
			else
				SlowFall = 25;

			if(Level < 2)
			{
				return "None";
			}
			if(Level >= 2)
				returnString += "hiraishin +" + Hiraishin;
			if(Level >= 5)
				returnString += ", up the walls";
			if(Level >= 11)
				returnString += ", slow fall (" + SlowFall + " feet)";


			return returnString;
		}
		public static string GetHyoumaSQ(int Level)
		{
			string returnString = "";
			int ColdBlood;
			string Hyouma;
			int ColdResist;
			
			if(Level >= 20)
				ColdBlood = 4;
			else if (Level >= 16)
				ColdBlood = 3;
			else if (Level >= 10)
				ColdBlood = 2;
			else
				ColdBlood = 1;

			if(Level >= 18)
				ColdResist = 20;
			else if (Level >= 14)
				ColdResist = 15;
			else 
				ColdResist = 10;

			if(Level >= 12)
				Hyouma = "full";
			else
				Hyouma = "half";

			if(Level < 2)
				return "None";
			if(Level >= 2)
				returnString += "cold blooded +" + ColdBlood;
			if(Level >= 4)
				returnString += ", hyouma (" + Hyouma + ")";
			if(Level >= 6)
				returnString += ", arctic protection " + ColdResist;
			if(Level >= 8)
				returnString += ", arctic tracking";

			return returnString;
		}
		public static string GetKamitoraSQ(int Level)
		{
			string returnString = "";

			string MonsterSummon;
			
			if(Level >= 17)
				MonsterSummon = "IV";
			else if(Level >= 12)
				MonsterSummon = "III";
			else if(Level >= 7)
				MonsterSummon = "II";
			else
				MonsterSummon = "I";

			if(Level < 2)
				return "None";
			if(Level >= 2)
				returnString += "monster summoner " + MonsterSummon;
			if(Level >= 4)
				returnString += ", ink vision";
			if(Level >= 10)
				returnString += ", advanced monster summoner";

			return returnString;
		}
		public static string GetKatsuganSQ(int Level)
		{
			string returnString = "";
			int LightSen;
			int KeenSight;
			int HighSight;
			int GazePred;
			int Darkvision;

			if(Level >= 18)
				Darkvision = 90;
			else
				Darkvision = 30;

			if(Level >= 16)
				LightSen = 3;
			else if(Level >= 6)
				LightSen = 2;
			else
				LightSen = 1;

			if(Level >= 15)
				KeenSight = 6;
			else if(Level >= 9)
				KeenSight = 4;
			else
				KeenSight = 2;

			if(Level >= 19)
				HighSight = 3;
			else
				HighSight = 1;

			if(Level >= 12)
				GazePred = 2;
			else
				GazePred = 1;

			returnString += "light sensitivity -" + LightSen;

			if(Level >= 3)
				returnString += ", keen sight +" + KeenSight;
			if(Level >= 4)
				returnString += ", darkvision " + Darkvision + "ft.";
			if(Level >= 7)
				returnString += ", gaze of the predator +" + GazePred;
			if(Level >= 10)
				returnString += ", high speed sight " + HighSight;
			if(Level >= 13)
				returnString += ", far sight";

			return returnString;
		}
		public static string GetKikaiSQ(int Level)
		{
			string returnString = "";
			int fraility;
			int BloodTraits;

			if(Level >= 19)
				fraility = 7;
			else if(Level >= 15)
				fraility = 5;
			else if(Level >= 11)
				fraility = 3;
			else
				fraility = 1;

			if(Level >= 20)
				BloodTraits = 4;
			else if(Level >= 16)
				BloodTraits = 3;
			else if(Level >= 12)
				BloodTraits = 2;
			else
				BloodTraits = 1;

			returnString += "kikai host";

			if(Level >= 4)
				returnString += ", fraility -" + fraility;
			if(Level >= 5)
				returnString += ", reserve";
			if(Level >= 8)
				returnString += ", bloodline traits +" + BloodTraits;


			return returnString;

		}
		public static string GetKyuushouSQ(int Level)
		{
			string returnString = "";
			string ExtendedLife;
			int Psuedo;
			int DFort;

			if(Level >= 16)
				ExtendedLife = "2d20+20";
			else if(Level >= 11)
				ExtendedLife = "20";
			else if(Level >= 6)
				ExtendedLife = "15";
			else
				ExtendedLife = "10";

			if(Level >= 17)
				Psuedo = 4;
			else if(Level >= 12)
				Psuedo = 3;
			else if(Level >= 7)
				Psuedo = 2;
			else
				Psuedo = 1;

			if(Level >= 18)
				DFort = 4;
			else if(Level >= 13)
				DFort = 3;
			else if(Level >= 8)
				DFort = 2;
			else
				DFort = 1;

			returnString += "extended life (" + ExtendedLife + " years)";

			if(Level >= 2)
				returnString += ", pseudomortality " + Psuedo;
			if(Level >= 3)
				returnString += ", deathless fortitude +" + DFort;
			if(Level >= 10)
				returnString += ", ageless";




			return returnString;
		}
		public static string GetReikyouSQ(int Level)
		{
			string returnString = "";
			int SpiritPower;
			int SSoaring;

			if(Level >= 20)
				SpiritPower = 3;
			else if(Level >= 12)
				SpiritPower = 2;
			else
				SpiritPower = 1;

			if(Level >= 16)
				SSoaring = 4;
			else if(Level >= 13)
				SSoaring = 3;
			else if(Level >= 8)
				SSoaring = 2;
			else
				SSoaring = 1;

			if(Level < 4)
				return "none";
			if(Level >= 4)
				returnString += "spirit power +" + SpiritPower;
			if(Level >= 8)
				returnString += ", spirit soaring (" + SSoaring + "d4)";

			return returnString;
		}
		public static string GetSharinganMinorSQ(int Level)
		{
			string returnString = "";

			int Sharingan;
			int Offen;
			int HighSpeed;

			if(Level >= 15)
				Sharingan = 4;
			else if(Level >= 11)
				Sharingan = 3;
			else if(Level >= 9)
				Sharingan = 2;
			else
				Sharingan = 1;

			if(Level >= 13)
				Offen = 2;
			else
				Offen = 1;

			if(Level >= 19)
				HighSpeed = 3;
			else if(Level >= 17)
				HighSpeed = 2;
			else
				HighSpeed = 1;

			if(Level < 3)
				return "none";
			if(Level >= 3)
				returnString += "sharingan eye +" + Sharingan;
			if(Level >= 5)
				returnString += ", offensive foresight +" + Offen;
			if(Level >= 7)
				returnString += ", high speed sight " + HighSpeed;
			if(Level >= 12)
				returnString += ", glare";

			return returnString;
		}
		public static string GetSharinganMajorSQ(int Level)
		{
			string returnString = "";

			int Sharingan;
			int Offen;
			int HighSpeed;

			if(Level >= 19)
				Sharingan = 6;
			else if(Level >= 14)
				Sharingan = 5;
			else if(Level >= 11)
				Sharingan = 4;
			else if(Level >= 8)
				Sharingan = 3;
			else if(Level >= 6)
				Sharingan = 2;
			else
				Sharingan = 1;

			if(Level >= 16)
				Offen = 3;
			else if(Level >= 7)
				Offen = 2;
			else
				Offen = 1;

			if(Level >= 20)
				HighSpeed = 5;
			else if(Level >= 18)
				HighSpeed = 4;
			else if(Level >= 15)
				HighSpeed = 3;
			else if(Level >= 12)
				HighSpeed = 2;
			else
				HighSpeed = 1;

			if(Level < 2)
				return "none";
			if(Level >= 2)
				returnString += "sharingan eye +" + Sharingan;
			if(Level >= 3)
				returnString += ", offensive foresight +" + Offen;
			if(Level >= 4)
				returnString += ", high speed sight " + HighSpeed;
			if(Level >= 10)
				returnString += ", glare";

			return returnString;
		}
		public static string GetShinsoSQ(int Level)
		{
			string returnString = "";
			int DarkHerit;
			int BloodDrain;
			int LightSen;

			if(Level >= 20)
				DarkHerit = 4;
			else
				DarkHerit = 2;

			if(Level >= 17)
				BloodDrain = 10;
			else if(Level >= 13)
				BloodDrain = 8;
			else if(Level >= 9)
				BloodDrain = 6;
			else if(Level >= 5)
				BloodDrain = 4;
			else
				BloodDrain = 3;

			if(Level >= 18)
				LightSen = 3;
			else if(Level >= 10)
				LightSen = 2;
			else
				LightSen = 1;

			returnString += "dark heritage +" + DarkHerit;
			if(Level >= 2)
				returnString += ", blood drain(1d" + BloodDrain + ")";
			if(Level >= 3)
				returnString += ", light sensitivity -" + LightSen;
			if(Level >= 4)
				returnString += ", power of blood(hit points)";
			if(Level >= 8)
				returnString += ", power of blood(chakra)";
			if(Level >= 12)
				returnString += ", power of blood(ex)";
			if(Level >= 15)
				returnString += ", DR 1/chakra";
			if(Level >= 16)
				returnString += ", power of blood(su)";

			return returnString;
		}
		public static string GetShikotsuMinorSQ(int Level)
		{
			string returnString = "";
			string BoneWeapon;
			int BonePulse;

			if(Level >= 13)
				BoneWeapon = "small, medium, or large";
			else if(Level >= 7)
				BoneWeapon = "small or medium";
			else
				BoneWeapon = "small";

			if(Level >= 19)
				BonePulse = 3;
			else if(Level >= 16)
				BonePulse = 2;
			else
				BonePulse = 1;

			returnString += "bone weapon(" + BoneWeapon + ")";

			if(Level >= 4)
				returnString += ", bone armor";
			if(Level >= 10)
				returnString += ", dead bone pulse +" + BonePulse;

			return returnString;
		}
		public static string GetShikotsuMedSQ(int Level)
		{
			string returnString = "";
			string BoneWeapon;
			int BonePulse;

			if(Level >= 9)
				BoneWeapon = "small, medium, or large";
			else if(Level >= 5)
				BoneWeapon = "small or medium";
			else
				BoneWeapon = "small";

			if(Level >= 19)
				BonePulse = 5;
			else if(Level >= 17)
				BonePulse = 4;
			else if(Level >= 15)
				BonePulse = 3;
			else if(Level >= 13)
				BonePulse = 2;
			else
				BonePulse = 1;

			returnString += "bone weapon(" + BoneWeapon + ")";

			if(Level >= 3)
				returnString += ", bone armor";
			if(Level >= 7)
				returnString += ", dead bone pulse +" + BonePulse;
			if(Level >= 11)
				returnString += ", extended life(10 years)";
			return returnString;
		}
		public static string GetShikotsuMajorSQ(int Level)
		{
			string returnString = "";
			string BoneWeapon;
			int BonePulse;
			int ExtendedLife;
			int Deathless;

			if(Level >= 8)
				BoneWeapon = "small, medium, or large";
			else if(Level >= 4)
				BoneWeapon = "small or medium";
			else
				BoneWeapon = "small";

			if(Level >= 17)
				BonePulse = 5;
			else if(Level >= 16)
				BonePulse = 4;
			else if(Level >= 13)
				BonePulse = 3;
			else if(Level >= 10)
				BonePulse = 2;
			else
				BonePulse = 1;

			if(Level >= 20)
				ExtendedLife = 25;
			else if(Level >= 14)
				ExtendedLife = 20;
			else
				ExtendedLife = 10;

			if(Level >= 19)
				Deathless = 2;
			else
				Deathless = 1;

			returnString += "bone weapon(" + BoneWeapon + ")";

			if(Level >= 2)
				returnString += ", bone armor";
			if(Level >= 5)
				returnString += ", extended life(" + ExtendedLife + " years)";
			if(Level >= 7)
				returnString += ", dead bone pulse +" + BonePulse;
			if(Level >= 11)
				returnString += ", deathless +" + Deathless;

			return returnString;
		}

		public static string GetSatoriMedSQ(int Level)
		{
			string returnString = "";

			int SenseMotive;
			int EyeOfTheHeart;
			int BladeAffinity;
			int DRAgainstSlashing;

			if(Level >= 16)
				SenseMotive = 3;
			else if(Level >= 10)
				SenseMotive = 2;
			else
				SenseMotive = 1;

			if(Level >= 18)
				EyeOfTheHeart = 3;
			else if(Level >= 12)
				EyeOfTheHeart = 2;
			else
				EyeOfTheHeart = 1;

			if(Level >= 14)
				BladeAffinity = 2;
			else
				BladeAffinity = 1;

			if(Level >= 20)
				DRAgainstSlashing = 2;
			else
				DRAgainstSlashing = 1;

			if(Level >= 2)
				returnString += "sense motive +" + SenseMotive;
			if(Level >= 4)
				returnString += ", eye of the heart +" + EyeOfTheHeart;
			if(Level >= 6)
				returnString += ", DR " + DRAgainstSlashing + "/bludgeoning or piercing";
			if(Level >= 8)
				returnString += ", blade affinity +" + BladeAffinity;

            return returnString;
		}

		public static string GetSatoriMajorSQ(int Level)
		{
			string returnString = "";

			int SenseMotive;
			int EyeOfTheHeart;
			int BladeAffinity;
			int DRAgainstSlashing;
			int Satori;

			if(Level >= 16)
				SenseMotive = 6;
			else if(Level >= 9)
				SenseMotive = 4;
			else
				SenseMotive = 2;

			if(Level >= 15)
				EyeOfTheHeart = 3;
			else if(Level >= 10)
				EyeOfTheHeart = 2;
			else
				EyeOfTheHeart = 1;

			if(Level >= 18)
				BladeAffinity = 3;
			else if(Level >= 13)
				BladeAffinity = 2;
			else
				BladeAffinity = 1;

			if(Level >= 19)
				DRAgainstSlashing = 2;
			else
				DRAgainstSlashing = 1;

			if(Level >= 20)
				Satori = 30;
			else if(Level >= 12)
				Satori = 20;
			else
				Satori = 10;

			if(Level >= 1)
				returnString += "sense motive +" + SenseMotive;
			if(Level >= 3)
				returnString += "satori (" + Satori + " feet)";
			if(Level >= 4)
				returnString += ", eye of the heart +" + EyeOfTheHeart;
			if(Level >= 6)
				returnString += ", DR " + DRAgainstSlashing + "/bludgeoning or piercing";
			if(Level >= 7)
				returnString += ", blade affinity +" + BladeAffinity;

			return returnString;
		}

        public static string GetDemonSQ(int Level)
        {
            if (Level >= 20)
                return "Acid immunity, cold resistance 30, empty body, fast healing 10, negative energy immunity, sense chakra, suppress chakra.";
            else if (Level >= 8)
                return "Darkvision 60 feet, damage reduction 10/chakra, ethereal blast, ethereal shift, frightful presence, immunities, low-light vision, pseudophysical, sense chakra, suppress chakra.";
            else if (Level >= 6)
                return "Darkvision 60 feet, ethereal blast, ethereal shift, immunities, low-light vision, pseudophysical, sense chakra.";
            else if (Level >= 4)
                return "Darkvision 60 feet, ethereal blast, immunities, low-light vision, pseudophysical.";
            else
                return "Immunities, low-light vision, pseudophysical.";
        }
	}
}
