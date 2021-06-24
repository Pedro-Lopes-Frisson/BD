using System;

namespace VirtualShopC.Objetos
{
    [Serializable()]
    public class Shield
    {

        public string SpecialAbility;
        public string Price;
        public string Name;
        public string isUnique;
        public string Upgraded;
        public string Rank;
        public string TabNumber;
        public string Stash_ID;
        public string ID;
        public string Defense;

        public Shield(string specialAbility, string price, string name, string isUnique, string upgraded, string rank, string tabNumber, string stash_ID, string iD, string defense)
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
        public Shield() { }
        public override string ToString()
        {
            return SpecialAbility + Price + Name + isUnique + Upgraded + Rank + TabNumber + Stash_ID + ID + Defense;
        }
    }
}
