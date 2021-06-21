namespace shield
{
    [Serializable()]
    public class shield
    {

        private String _SpecialAbility;
        private String _Price;
        private String _Name;
        private String _isUnique;
        private String _Upgraded;
        private String _Rank;
        private String _TabNumber;
        private String _Stash_ID;
        private String _ID;
        private String _Defense;
        public String ID
        {
            get { return _ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("ID field cant be empty");
                    return;
                }
                _ID = value;
            }
        }

        public String Defense
        {
            get { return _Defense; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Defense field cant be empty");
                    return;
                }
                _Defense = value;
            }
        }
        public String SpecialAbility
        {
            get { return _SpecialAbility; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("SpecialAbility field cant be empty");
                    return;
                }
                _SpecialAbility = value;
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

    }
}
