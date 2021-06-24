using System;

namespace VirtualShopC.Objetos
{
    [Serializable()]
    public class Physical
    {
        public string CriticalMutiplier;
        public string Range;
        public string Accuraccy;
        public string item_ID;
        public string PiercingRate;
        public string FireRate;
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

        public Physical(string criticalMutiplier, string range, string accuraccy, string item, string piercingRate, string fireRate, string price, string name, string isUnique, string upgraded, string rank, string tabNumber, string stash_ID, string specialAttributes, string damage, string damageType, string criticalChance)
        {
            CriticalMutiplier = criticalMutiplier;
            Range = range;
            Accuraccy = accuraccy;
            item_ID = item;
            PiercingRate = piercingRate;
            FireRate = fireRate;
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
        }
        public Physical() { }

        public override string ToString()
        {
            return CriticalMutiplier + Range + Accuraccy + item_ID + PiercingRate + FireRate + Price + Name + isUnique + Upgraded + Rank + TabNumber + Stash_ID + SpecialAttributes + Damage + DamageType + CriticalChance;
        }
    }
}
