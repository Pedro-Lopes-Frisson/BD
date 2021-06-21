namespace SpecialItem
{
    [Serializable()]
    public class specialItem
    {
        private String _Name;
        private String _Price;
        private String _CurrencyType;
        private String _Rank;
        private String _ID;

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
        public String CurrencyType
        {
            get { return _CurrencyType; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CurrencyType field cant be empty");
                    return;
                }
                _CurrencyType = value;
            }
        }
        public String Rank
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CurrencyType field cant be empty");
                    return;
                }
            }
        }
    }
}
