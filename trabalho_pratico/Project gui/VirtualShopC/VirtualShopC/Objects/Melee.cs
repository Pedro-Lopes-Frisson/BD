namespace melee
{
    [Serializable()]
    public class melee
    {
        private String _Weapon_ID;
        private String _AttackSpeed;
        private String _HandNum;
        private String _MeleeType;
        private String _Price;
        private String _Name;
        private String _isUnique;
        private String _Upgraded;
        private String _Rank;
        private String _TabNumber;
        private String _Stash_ID;
        private String _SpecialAttributes;
        private String _Damage;
        private String _DamageType;
        private String _CriticalChance;
        private String _CriticalMutiplier;
        public String Weapon_ID
        {
            get { return _Weapon_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Weapon_ID field cant be empty");
                    return;
                }
                _Weapon_ID = value;
            }
        }
        public String AttackSpeed
        {
            get { return _AttackSpeed; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("AttackSpeed field cant be empty");
                    return;
                }
                _AttackSpeed = value;
            }
        }
        public String HandNum
        {
            get { return _HandNum; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("HandNum field cant be empty");
                    return;
                }
                _HandNum = value;
            }
        }
        public String MeleeType
        {
            get { return _MeleeType; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("MeleeType field cant be empty");
                    return;
                }
                _MeleeType = value;
            }
        }

        public String Price
        {
            get { return _Price; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Price field cant be empty");
                    return;
                }
                _Price = value;
            }
        }
        public String Name
        {
            get { return _Name; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Name field cant be empty");
                    return;
                }
                _Name = value;
            }
        }
        public String isUnique
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("isUniquefield cant be empty");
                    return;
                }
                _isUnique = value;
            }
        }
        public String Upgraded
        {
            get { return _Upgraded; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Upgraded field cant be empty");
                    return;
                }
                _Upgraded = value;
            }
        }
        public String Rank
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Rank field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        public String TabNumber
        {
            get { return _TabNumber; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("TabNumber field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        public String Stash_ID
        {
            get { return _Stash_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Stash_ID field cant be empty");
                    return;
                }
                _Stash_ID = value;
            }
        }

        public String SpecialAttributes
        {
            get { return _SpecialAttributes; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("SpecialAttributes field cant be empty");
                    return;
                }
                _SpecialAttributes = value;
            }
        }

        public String Damage
        {
            get { return _Damage; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Damage field cant be empty");
                    return;
                }
                _Damage = value;
            }
        }
        public String DamageType
        {
            get { return _DamageType; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("DamageType field cant be empty");
                    return;
                }
                _DamageType = value;
            }
        }
        public String CriticalChance
        {
            get { return _CriticalChance; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CriticalChance field cant be empty");
                    return;
                }
                _CriticalChance = value;
            }
        }
        public String CriticalMutiplier
        {
            get { return _CriticalMutiplier; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CriticalMutiplier field cant be empty");
                    return;
                }
                _CriticalMutiplier = value;
            }
        }

        public String CHECK
        {
            get { return _CHECK; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CHECK field cant be empty");
                    return;
                }
                _CHECK = value;
            }
        }

        public String CHECK
        {
            get { return _CHECK; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CHECK field cant be empty");
                    return;
                }
                _CHECK = value;
            }
        }




    }
}
