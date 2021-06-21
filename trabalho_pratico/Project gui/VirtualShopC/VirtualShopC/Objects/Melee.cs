using System;

namespace VirtualShopC.Objetos
{
    [Serializable()]
    public class Melee
    {
        public string Weapon_ID;
        public string AttackSpeed;
        public string HandNum;
        public string MeleeType;
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

        public Melee(string weapon_ID, string attackSpeed, string handNum, string meleeType, string price, string name, string isUnique, string upgraded, string rank, string tabNumber, string stash_ID, string specialAttributes, string damage, string damageType, string criticalChance, string criticalMutiplier)
        {
            Weapon_ID = weapon_ID;
            AttackSpeed = attackSpeed;
            HandNum = handNum;
            MeleeType = meleeType;
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
        public Melee() { }
        public override string ToString()
        {
            return Weapon_ID + AttackSpeed + HandNum + MeleeType + Price + Name + isUnique + Upgraded + Rank + TabNumber + Stash_ID + SpecialAttributes + Damage + DamageType + CriticalChance + CriticalMutiplier + Stash_ID;
        }

    }
}
