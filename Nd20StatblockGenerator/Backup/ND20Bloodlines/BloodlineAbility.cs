using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ND20Bloodlines
{
    [Serializable]
    public class BloodlineAbility
    {
        public string AbilityText = null;

        public List<BloodlineMapping> GrowthList = new List<BloodlineMapping>();

        public BloodlineTemplate AbilityTemplate = null;

        public BloodlineAbility()
        {

        }
    }

    [Serializable]
    public class BloodlineMapping
    {
        [XmlAttribute]
        public int Level;

        [XmlAttribute]
        public int AttackValue;

        [XmlAttribute]
        public string Text;

        public BloodlineMapping(int _Level, int _AttackValue, string _Text)
        {
            Level = _Level;
            AttackValue = _AttackValue;
            Text = _Text;
        }

        public BloodlineMapping()
        {

        }
    }
}
