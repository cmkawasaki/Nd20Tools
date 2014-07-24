using System;
using System.Collections.Generic;
using System.Text;

namespace Nd20TemplateLib
{
    [Serializable]
    public class DefenseStat
    {
        public List<DefenseModifier> MyModifiers;

        public DefenseStat()
        {
            MyModifiers = new List<DefenseModifier>();
        }

        public void AddModifier(DefenseModifier MyModifier)
        {
            bool Added = false;

            for(int i = 0; i < MyModifiers.Count; i++)
            {
                if (MyModifiers[i].Type == MyModifier.Type)
                {
                    MyModifiers[i].Bonus += MyModifier.Bonus;
                    Added = true;
                }
            }

            if (false == Added)
            {
                MyModifiers.Add(MyModifier);
            }
        }

        public int FetchModifier(string DefenseString)
        {
            for (int i = 0; i < MyModifiers.Count; i++)
            {
                if (MyModifiers[i].Type.ToLower() == DefenseString.ToLower())
                {
                    return MyModifiers[i].Bonus;
                }
            }

            return 0;
        }

        public void AddModifier(string Type, int Bonus, bool DexBased, bool ArmorBased)
        {
            DefenseModifier MyModifier = new DefenseModifier(Type, Bonus, DexBased, ArmorBased);
            AddModifier(MyModifier);
        }

        public void SetModifier(string Type, int Bonus)
        {
            for (int i = 0; i < MyModifiers.Count; i++)
            {
                if (MyModifiers[i].Type == Type)
                {
                    MyModifiers[i].Bonus = Bonus;
                    return;
                }
            }
        }

        public int RemoveModifier(string Type)
        {
            foreach (DefenseModifier Mod in MyModifiers)
            {
                if (Mod.Type == Type.ToLower())
                {
                    MyModifiers.Remove(Mod);
                    return 0;
                }
            }

            return -1;
        }

        public override string ToString()
        {
            int TotalDefense = 0;
            int TouchDefense = 0;
            int FlatFootedDefense = 0;

            GetDefenses(ref TotalDefense, ref TouchDefense, ref FlatFootedDefense);

            string ReturnString = "";

            ReturnString += "Defense";
            ReturnString += " " + TotalDefense;

            ReturnString += ", touch " + TouchDefense + ", flat-footed " + FlatFootedDefense + " ";

            ReturnString += PrintModifiers() + "; ";

            return ReturnString;
        }

        public string ToStringRTF()
        {
            int TotalDefense = 0;
            int TouchDefense = 0;
            int FlatFootedDefense = 0;

            GetDefenses(ref TotalDefense, ref TouchDefense, ref FlatFootedDefense);

            string ReturnString = "";

            ReturnString += RTFWriter.FormatWithBold("Defense");
            ReturnString += " " + TotalDefense;

            ReturnString += ", touch " + TouchDefense + ", flat-footed " + FlatFootedDefense + " ";

            ReturnString += PrintModifiers() + "; ";

            return ReturnString;
        }

        private string PrintModifiers()
        {
            string ReturnString = "";

            ReturnString += "(";

            for(int i = 0; i < MyModifiers.Count; i++)
            {
                if (0 <= MyModifiers[i].Bonus)
                {
                    ReturnString += "+";
                }

                ReturnString += MyModifiers[i].Bonus;

                ReturnString += " " + MyModifiers[i].Type;

                if (i != MyModifiers.Count - 1)
                {
                    ReturnString += ", ";
                }
            }

            ReturnString += ")";

            return ReturnString;
        }

        private void GetDefenses(ref int TotalDefense, ref int TouchDefense, ref int FlatFootedDefense)
        {
            TotalDefense = 10;
            TouchDefense = 10;
            FlatFootedDefense = 10;

            foreach (DefenseModifier Mod in MyModifiers)
            {
                TotalDefense += Mod.Bonus;

                if (false == Mod.ArmorBased)
                {
                    TouchDefense += Mod.Bonus;
                }

                if (true == Mod.DexBased)
                {
                    if (0 > Mod.Bonus)
                    {
                        FlatFootedDefense += Mod.Bonus;
                    }
                }
                else
                {
                    FlatFootedDefense += Mod.Bonus;
                }
            }
        }

        public void Consume(DefenseStat DefenseToBeConsumed)
        {
            if (null != DefenseToBeConsumed)
            {
                foreach (DefenseModifier MyMod in DefenseToBeConsumed.MyModifiers)
                {
                    this.AddModifier(MyMod);
                }
            }
        }
    }

    [Serializable]
    public class DefenseModifier
    {
        public string Type;

        public int Bonus;

        public bool DexBased;

        public bool ArmorBased;

        public DefenseModifier()
        {

        }

        public DefenseModifier(string type, int bonus, bool dexBased, bool armorBased)
        {
            Type = type.ToLower();
            Bonus = bonus;
            DexBased = dexBased;
            ArmorBased = armorBased;
        }
    }
}
