using System;

namespace VirtualShopC.Objetos
{
    [Serializable()]
    public class Weapon
    {
        public string SpecialAttributes;
        public string Damage;
        public string DamageType;
        public string CriticalChance;
        public string CriticalMutiplier;
        public string Price;
        public string Name;
        public string isUnique;
        public string Upgraded;
        public string Rank;
        public string TabNumber;
        public string Stash_ID;
        public string item_ID;

        public Weapon(string specialAttributes, string damage, string damageType, string criticalChance, string criticalMutiplier, string price, string name, string isUnique, string upgraded, string rank, string tabNumber, string stash_ID, string item_ID)
        {
            SpecialAttributes = specialAttributes;
            Damage = damage;
            DamageType = damageType;
            CriticalChance = criticalChance;
            CriticalMutiplier = criticalMutiplier;
            Price = price;
            Name = name;
            this.isUnique = isUnique;
            Upgraded = upgraded;
            Rank = rank;
            TabNumber = tabNumber;
            Stash_ID = stash_ID;
            this.item_ID = item_ID;
        }

        public override string ToString()
        {
            return  this.SpecialAttributes + Damage+ DamageType+ CriticalChance+ CriticalMutiplier+ Price+ Name+ isUnique+ Upgraded+ Rank+ TabNumber+ Stash_ID+ item_ID;
        }
    }
}
