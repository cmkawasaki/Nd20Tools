using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Nd20TemplateLib
{
    public enum WeaponCategory
    {
        Primary,
        Secondary,
        Human
    }

    [Serializable]
    public class CharWeapon
    {
        public string Name;
        public string CustomName;
        public int NumberofDice;
        public int DieType;
        public double StrModMultiplier;
        [DefaultValue(0)]
        public int BonusToHit;
        [DefaultValue(0)]
        public int BonusToDamage;
        public AttackType WeaponType;
        public WeaponCategory WeaponCategory;

        public CharWeapon()
        {

        }

        public CharWeapon(string WeaponName, string CustomWeaponName, int DiceNumber, int MyDieType, double ModMultiplier, int HitMastercraft, int DamageMastercraft, AttackType NewWeaponType)
        {
            Name = WeaponName;
            CustomName = CustomWeaponName;
            NumberofDice = DiceNumber;
            DieType = MyDieType;
            StrModMultiplier = ModMultiplier;
            BonusToHit = HitMastercraft;
            BonusToDamage = DamageMastercraft;
            WeaponType = NewWeaponType;
        }
    }
}
