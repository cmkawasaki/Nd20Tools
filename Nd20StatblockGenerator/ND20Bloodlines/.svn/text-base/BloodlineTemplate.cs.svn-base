using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace ND20Bloodlines
{
    [Serializable]
    public class BloodlineTemplate
    {
        [DefaultValue(0)]
        public int InitBonus = 0;

        [DefaultValue(0)]
        public int AttackBonus = 0;

        [DefaultValue(0)]
        public int DefenseBonus = 0;

        [DefaultValue(0)]
        public int FortBonus = 0;

        [DefaultValue(0)]
        public int ReflexBonus = 0;

        [DefaultValue(0)]
        public int WillBonus = 0;

        [DefaultValue(0)]
        public int StrBonus = 0;

        [DefaultValue(0)]
        public int DexBonus = 0;

        [DefaultValue(0)]
        public int ConBonus = 0;

        [DefaultValue(0)]
        public int IntBonus = 0;

        [DefaultValue(0)]
        public int WisBonus = 0;

        [DefaultValue(0)]
        public int ChaBonus = 0;

        [DefaultValue(0)]
        public int StrRankBonus = 0;

        [DefaultValue(0)]
        public int SpeedRankBonus = 0;

        public BloodlineTemplate()
        {

        }

        #region Public Interface
        public void MultiplyTemplate(int Value)
        {
            InitBonus = InitBonus * Value;
            AttackBonus = AttackBonus * Value;
            DefenseBonus = DefenseBonus * Value;
            FortBonus = FortBonus * Value;
            ReflexBonus = ReflexBonus * Value;
            WillBonus = WillBonus * Value;
            StrBonus = StrBonus * Value;
            DexBonus = DexBonus * Value;
            ConBonus = ConBonus * Value;
            IntBonus = IntBonus * Value;
            WisBonus = WisBonus * Value;
            ChaBonus = ChaBonus * Value;
            StrRankBonus = StrRankBonus * Value;
            SpeedRankBonus = SpeedRankBonus * Value;
        }

        public void ConsumeTemplate(BloodlineTemplate TemToBeConsumed)
        {
            InitBonus += TemToBeConsumed.InitBonus;
            AttackBonus += TemToBeConsumed.AttackBonus;
            DefenseBonus += TemToBeConsumed.DefenseBonus;
            FortBonus += TemToBeConsumed.FortBonus;
            ReflexBonus += TemToBeConsumed.ReflexBonus;
            WillBonus += TemToBeConsumed.WillBonus;
            StrBonus += TemToBeConsumed.StrBonus;
            DexBonus += TemToBeConsumed.DexBonus;
            ConBonus += TemToBeConsumed.ConBonus;
            IntBonus += TemToBeConsumed.IntBonus;
            WisBonus += TemToBeConsumed.WisBonus;
            ChaBonus += TemToBeConsumed.ChaBonus;
            StrRankBonus += TemToBeConsumed.StrRankBonus;
            SpeedRankBonus += TemToBeConsumed.SpeedRankBonus;
        }

        public bool IsZeroTemplate()
        {
            if (InitBonus == 0 && AttackBonus == 0 && DefenseBonus == 0 &&
                FortBonus == 0 && ReflexBonus == 0 && WillBonus == 0 &&
                StrBonus == 0 && DexBonus == 0 && ConBonus == 0 &&
                IntBonus == 0 && WisBonus == 0 && ChaBonus == 0 &&
                StrRankBonus == 0 && SpeedRankBonus == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
