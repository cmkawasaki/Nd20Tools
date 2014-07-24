using System;
using System.Collections.Generic;
using System.Text;
using Nd20TemplateLib;
using System.Xml.Serialization;

namespace Nd20StatblockGenerator
{
    [Serializable]
    public class XMLRace : IRace
    {
        public string Name;
        public bool PossessesRacialClass;
        public RaceHDType HDType;
        public CharacterStats RacialStats;
        public XMLCharacterClass RacialClass;
        public CharacterSize.CharacterSizeEnum RacialSize;
        public int CharacterSpeed;
        public int BonusSkillPoints;
        public int BonusFeats;
        public string SpecialQualities;
        public DefenseStat RacialDefense;
        public int ClassCR;
        public int ClassECL;

        public enum RaceHDType
        {
            AVERAGE,
            MAXIMUM
        };

        public override bool PossessesRacialHD()
        {
            return PossessesRacialClass;
        }

        public override string GetTitleText()
        {
            return Name;
        }

        public override int GetAverageHP(List<ClassStatEntry> MyList, int ConMod, int BonusHPFromPower)
        {
            if (HDType == RaceHDType.MAXIMUM)
            {
                int AveHP = 0;
                int TotalLevel = 0;

                foreach (ClassStatEntry MyEntry in MyList)
                {
                    AveHP += (int)(((MyEntry.HDType) + ConMod + BonusHPFromPower) * MyEntry.ClassLevel);
                    TotalLevel += MyEntry.ClassLevel;
                }
                AveHP = GetMax(TotalLevel, AveHP);

                return AveHP;
            }
            else
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
        }

        public override NPCTemplate CreateTemplate(NPCTemplate SourceTemplate)
        {
            NPCTemplate newTemplate = new NPCTemplate("", ClassCR, ClassECL, 0, 0, 0, "", 0, 0, 0, 0, 0, 0, RacialStats, 0, 0, CharacterSpeed, SpecialQualities, null);

            newTemplate.CharacterName = SourceTemplate.CharacterName;

            newTemplate.CharSize = RacialSize;

            newTemplate.BonusFeats = BonusFeats;
            newTemplate.BonusSkillPoints = BonusSkillPoints;

            if (null != RacialClass)
            {
                CharacterStats levelStats;

                if (null != RacialStats)
                {
                    levelStats = new CharacterStats();
                    levelStats.StrScore = SourceTemplate.BaseStats.StrScore + RacialStats.StrScore;
                    levelStats.DexScore = SourceTemplate.BaseStats.DexScore + RacialStats.DexScore;
                    levelStats.ConScore = SourceTemplate.BaseStats.ConScore + RacialStats.ConScore;
                    levelStats.IntScore = SourceTemplate.BaseStats.IntScore + RacialStats.IntScore;
                    levelStats.WisScore = SourceTemplate.BaseStats.WisScore + RacialStats.WisScore;
                    levelStats.ChaScore = SourceTemplate.BaseStats.ChaScore + RacialStats.ChaScore;
                }
                else
                {
                    levelStats = SourceTemplate.BaseStats;
                }

                NPCTemplate raceTemplate = RacialClass.CreateClassTemplate(RacialClass.MaxLevel, 1, RacialClass.MaxLevel, levelStats, 0);
                raceTemplate.TemplateCR = 0;
                raceTemplate.TemplateECL = 0;
                newTemplate.ConsumeTemplate(raceTemplate);
            }

            //Insert Racial Defense
            if (null != RacialDefense)
            {
                newTemplate.TemplateDefense = RacialDefense;
            }
            else
            {
                newTemplate.TemplateDefense = new DefenseStat();
            }

            return newTemplate;
        }

        public override string GetXPText()
        {
            throw new NotImplementedException();
        }

        public override string GetFlavorText()
        {
            throw new NotImplementedException();
        }
    }
}
