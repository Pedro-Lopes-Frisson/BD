using System;

namespace VirtualShopC.Objetos
{
    [Serializable()]
    public class Armor
    {

        public string SpecialAttributes;
        public string Defense;
        public string HealthBonus;
        public string Price;
        public string Name;
        public string isUnique;
        public string Upgraded;
        public string Rank;
        public string TabNumber;
        public string Stash_ID;
        public string ID;

        public Armor(string specialAttributes, string defense, string healthBonus, string price, string name, string isUnique, string upgraded, string rank, string tabNumber, string stash_ID, string iD)
        {
            SpecialAttributes = specialAttributes;
            Defense = defense;
            HealthBonus = healthBonus;
            Price = price;
            Name = name;
            this.isUnique = isUnique;
            Upgraded = upgraded;
            Rank = rank;
            TabNumber = tabNumber;
            Stash_ID = stash_ID;
            ID = iD;
        }
        public Armor() { }
        public override string ToString()
        {
            return SpecialAttributes+ Defense+ HealthBonus+ Price+ Name+ isUnique+ Upgraded+ Rank+ TabNumber+ Stash_ID+ ID;
        }
    }
}
