using System;

namespace Ranged
{
    [Serializable()]
    public class Ranged
    {
        public string item_ID;
        public string Range;
        public string Accuraccy;
        public string Price;
        public string Name;
        public string isUnique;
        public string Upgraded;
        public string Rank;
        public string TabNumber;
        public string Stash_ID;
        public string SpecialAttributes;
        public string Damage;
        public string DamageType;
        public string CriticalChance;
        public string CriticalMutiplier;

        public Ranged(string item_ID, string range, string accuraccy, string price, string name, string isUnique, string upgraded, string rank, string tabNumber, string stash_ID, string specialAttributes, string damage, string damageType, string criticalChance, string criticalMutiplier)
        {
            this.item_ID = item_ID;
            Range = range;
            Accuraccy = accuraccy;
            Price = price;
            Name = name;
            this.isUnique = isUnique;
            Upgraded = upgraded;
            Rank = rank;
            TabNumber = tabNumber;
            Stash_ID = stash_ID;
            SpecialAttributes = specialAttributes;
            Damage = damage;
            DamageType = damageType;
            CriticalChance = criticalChance;
            CriticalMutiplier = criticalMutiplier;
        }
        public Ranged() { }
        public override string ToString()
        {
            return item_ID+ Range+ Accuraccy+ Price+ Name+ isUnique+ Upgraded+ Rank+ TabNumber+ Stash_ID+ SpecialAttributes+ Damage+ DamageType+ CriticalChance+ CriticalMutiplier;
        }
    }
}
