using System;

namespace VirtualShopC.Objetos
{
    [Serializable()]
    public class Armor
    {

        private string SpecialAttributes;
        private string Defense;
        private string HealthBonus;
        private string Price;
        private string Name;
        private string isUnique;
        private string Upgraded;
        private string Rank;
        private string TabNumber;
        private string Stash_ID;
        private string ID;

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
