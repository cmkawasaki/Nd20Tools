using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    public enum AttackType
    {
        MELEE,
        RANGED
    };

    public class AttackStat
    {
        public int BAB = 0;

        private int MeleeAttackToHitMod = 0;
        private int RangedAttackToHitMod = 0;
        private int GrappleAttackMod = 0;

        private int GrappleStatMod = 0;
        private int MeleeStatMod = 0;
        private int RangedStatMod = 0;

        public int MAX_ATTACK_COUNT = 4;

        public List<CharWeapon> CharacterWeapons = new List<CharWeapon>(); 

        public void AddAttackMod(int Bonus, bool MeleeType, bool RangedType, bool GrappleType)
        {
            if (true == MeleeType)
            {
                MeleeAttackToHitMod += Bonus;
            }
            if (true == RangedType)
            {
                RangedAttackToHitMod += Bonus;
            }
            if (true == GrappleType)
            {
                GrappleAttackMod += Bonus;
            }
        }

        public void SetStatMods(int GrappleStat, int MeleeStat, int RangedStat)
        {
            GrappleStatMod = GrappleStat;
            MeleeStatMod = MeleeStat;
            RangedStatMod = RangedStat;
        }

        public void Consume(AttackStat AttackToBeConsumed)
        {
            BAB += AttackToBeConsumed.BAB;
            MeleeAttackToHitMod += AttackToBeConsumed.MeleeAttackToHitMod;
            RangedAttackToHitMod += AttackToBeConsumed.RangedAttackToHitMod;
            GrappleAttackMod += AttackToBeConsumed.GrappleAttackMod;

            MAX_ATTACK_COUNT = GetMinimum(AttackToBeConsumed.MAX_ATTACK_COUNT, MAX_ATTACK_COUNT);
        }

        public override string ToString()
        {
            string returnString = "";

            int GrappleTotal = BAB + GrappleStatMod + GrappleAttackMod;
            int MeleeTotal = BAB + MeleeStatMod + MeleeAttackToHitMod;
            int RangedTotal = BAB + RangedStatMod + RangedAttackToHitMod;

            //Set BAB
            returnString += "BAB";
            returnString += " +" + BAB + "; ";

            //Set Grapple
            returnString += "Grap";
            returnString += " ";

            if (GrappleTotal >= 0)
            {
                returnString += "+";
            }

            returnString += GrappleTotal + "; ";

            //Set Atk
            returnString += "Atk";
            returnString += " ";

            returnString += PrintAttackBody(false);

            returnString += " ";

            //Set Full Attack
            returnString += "Full Atk";
            returnString += " ";

            returnString += PrintAttackBody(true);

            return returnString;
        }

        public string ToStringRTF()
        {
            string returnString = "";

            int GrappleTotal = BAB + GrappleStatMod + GrappleAttackMod;
            int MeleeTotal = BAB + MeleeStatMod + MeleeAttackToHitMod;
            int RangedTotal = BAB + RangedStatMod + RangedAttackToHitMod;

            //Set BAB
            returnString += RTFWriter.FormatWithBold("BAB");
            returnString += " +" + BAB + "; ";

            //Set Grapple
            returnString += RTFWriter.FormatWithBold("Grap");
            returnString += " ";

            if (GrappleTotal >= 0)
            {
                returnString += "+";
            }

            returnString += GrappleTotal + "; ";

            //Set Atk
            returnString += RTFWriter.FormatWithBold("Atk");
            returnString += " ";

            returnString += PrintAttackBody(false);

            //Set Full Attack
            returnString += RTFWriter.FormatWithBold("Full Atk");
            returnString += " ";

            returnString += PrintAttackBody(true);

            return returnString;
        }

        private string PrintAttackBody(bool FullAttackOrNot)
        {
            string returnString = "";

            returnString += PrintAttacksByGroup(AttackType.MELEE, FullAttackOrNot);

            returnString += " or ";

            returnString += PrintAttacksByGroup(AttackType.RANGED, FullAttackOrNot);

            returnString += "; ";

            return returnString;
        }

        private string PrintAttacksByGroup(AttackType AttackTypeToPrint, bool FullAttackOrNot)
        {
            string returnString = "";

            foreach (CharWeapon Weapon in CharacterWeapons)
            {
                if (AttackTypeToPrint == Weapon.WeaponType)
                {
                    returnString += PrintAttackType(AttackTypeToPrint, FullAttackOrNot, Weapon);

                    returnString += " or ";
                }
            }

            returnString += PrintAttackType(AttackTypeToPrint, FullAttackOrNot, null);

            return returnString;
        }

        public string PrintAttackType(AttackType MyAttack, bool FullAttackOrNot, CharWeapon WeaponToPrint)
        {
            string returnString = "";

            int AttackBonus;
            string TypeOfAttack;
            int FullAttackCount;

            int WeaponBonus = 0;

            if (null != WeaponToPrint)
            {
                WeaponBonus = WeaponToPrint.BonusToHit;
            }

            if (true == FullAttackOrNot)
            {
                FullAttackCount = GetMinimum((int)((BAB-1) / 5) + 1, MAX_ATTACK_COUNT);
            }
            else
            {
                FullAttackCount = 1;
            }

            switch (MyAttack)
            {
                case AttackType.MELEE:
                    AttackBonus = BAB + MeleeStatMod + MeleeAttackToHitMod + WeaponBonus;
                    TypeOfAttack = "melee";
                    break;
                case AttackType.RANGED:
                    AttackBonus = BAB + RangedStatMod + RangedAttackToHitMod + WeaponBonus;
                    TypeOfAttack = "ranged";
                    break;
                default:
                    return "";
            }

            for (int i = 0; i < FullAttackCount; i++)
            {
                if (i > 0)
                {
                    returnString += "/";
                }

                if (AttackBonus >= 0)
                {
                    returnString += "+";
                }
                returnString += AttackBonus;
                AttackBonus -= 5;
            }

            returnString += " " + TypeOfAttack + " ";

            if (null == WeaponToPrint)
            {
                returnString += "(by weapon)";
            }
            else
            {
                //Print Weapon Block
                returnString += "(" + WeaponToPrint.NumberofDice + "d" + WeaponToPrint.DieType;

                int DamageBonus = (int)(MeleeStatMod * WeaponToPrint.StrModMultiplier) + WeaponToPrint.BonusToDamage;

                if (DamageBonus > 0)
                {
                    returnString += "+";
                }

                if (null == WeaponToPrint.CustomName)
                {
                    returnString += DamageBonus + ", " + WeaponToPrint.Name + ")";
                }
                else
                {
                    returnString += DamageBonus + ", " + WeaponToPrint.CustomName + ")";
                }
            }

            return returnString;
        }

        public int GetMinimum(int A, int B)
        {
            if (A < B)
                return A;
            else
                return B;
        }

        public AttackStat()
        {

        }

        public AttackStat(int StrMod, int DexMod)
        {
            GrappleStatMod = StrMod;
            MeleeStatMod = StrMod;
            RangedStatMod = DexMod;
        }
    }
}
