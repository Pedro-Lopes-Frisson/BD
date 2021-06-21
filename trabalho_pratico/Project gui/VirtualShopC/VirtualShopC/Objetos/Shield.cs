using System;

namespace shield
{
    [Serializable()]
    public class shield
    {

        public String SpecialAbility;
        public String Price;
        public String Name;
        public String isUnique;
        public String Upgraded;
        public String Rank;
        public String TabNumber;
        public String Stash_ID;
        public String ID;
        public String Defense;

        public shield(string specialAbility, string price, string name, string isUnique, string upgraded, string rank, string tabNumber, string stash_ID, string iD, string defense)
        {
            SpecialAbility = specialAbility;
            Price = price;
            Name = name;
            this.isUnique = isUnique;
            Upgraded = upgraded;
            Rank = rank;
            TabNumber = tabNumber;
            Stash_ID = stash_ID;
            ID = iD;
            Defense = defense;
        }
        public override string ToString()
        {
            return SpecialAbility+ Price+ Name+ isUnique+ Upgraded+ Rank+ TabNumber+ Stash_ID+ ID+ Defense;
        }
    }
}
