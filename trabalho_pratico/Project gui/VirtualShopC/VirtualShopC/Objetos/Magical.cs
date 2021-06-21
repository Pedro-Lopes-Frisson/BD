using System;

namespace VirtualShopC.Objetos
{
    [Serializable()]
    public class Magical
    {
        public string SpecialAttributes;
        public string Damage;
        public string DamageType;
        public string CriticalChance;
        public string CriticalMutiplier;
        public string Range;
        public string Accuraccy;
        public string item_ID;
        public string CoolDown;
        public string RadiusOfEffectiveness;
        public string Price;
        public string Name;
        public string isUnique;
        public string Upgraded;
        public string Rank;
        public string TabNumber;
        public string Stash_ID;

        public Magical(string specialAttributes, string damage, string damageType, string criticalChance, string criticalMutiplier, string range, string accuraccy, string item_ID, string coolDown, string radiusOfEffectiveness, string price, string name, string isUnique, string upgraded, string rank, string tabNumber, string stash_ID)
        {
            SpecialAttributes = specialAttributes;
            Damage = damage;
            DamageType = damageType;
            CriticalChance = criticalChance;
            CriticalMutiplier = criticalMutiplier;
            Range = range;
            Accuraccy = accuraccy;
            this.item_ID = item_ID;
            CoolDown = coolDown;
            RadiusOfEffectiveness = radiusOfEffectiveness;
            Price = price;
            Name = name;
            this.isUnique = isUnique;
            Upgraded = upgraded;
            Rank = rank;
            TabNumber = tabNumber;
            Stash_ID = stash_ID;
        }
        public override string ToString()
        {
            return SpecialAttributes+ Damage+ DamageType+ CriticalChance+ CriticalMutiplier+ Range+ Accuraccy+ item_ID+ CoolDown+ RadiusOfEffectiveness+ Price+ Name+ isUnique+ Upgraded+ Rank+ TabNumber+ Stash_ID;
        }
    }
}
