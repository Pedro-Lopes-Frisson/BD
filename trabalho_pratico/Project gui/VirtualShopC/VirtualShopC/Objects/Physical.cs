namespace physical
{
    [Serializable()]
    public class physical
    {
        private String _CriticalMutiplier;
        private String _Range;
        private String _Accuraccy;
        private String _item_ID;
        private String _PiercingRate;
        private String _FireRate;
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
        public String item_ID
        {
            get { return _item_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Range field cant be empty");
                    return;
                }
                _item_ID = value;
            }
        }
        public String PiercingRate
        {
            get { return _PiercingRate; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("PiercingRate field cant be empty");
                    return;
                }
                _PiercingRate = value;
            }
        }
        public String FireRate
        {
            get { return _FireRate; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("FireRate field cant be empty");
                    return;
                }
                _FireRate = value;
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


        public String Range
        {
            get { return _Range; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Range field cant be empty");
                    return;
                }
                _Range = value;
            }
        }
        public String Accuraccy
        {
            get { return _Accuraccy; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Accuraccy field cant be empty");
                    return;
                }
                _Accuraccy = value;
            }
        }



    }
}
