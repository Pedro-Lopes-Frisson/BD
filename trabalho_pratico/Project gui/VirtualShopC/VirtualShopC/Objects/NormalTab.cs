namespace normalTab
{
    [Serializable()]
    public class normalTab
    {
        private String _Stash_ID;
        private String _Number;
        private String _SlotSpace;
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
        public String Number
        {
            get { return _Number; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Number field cant be empty");
                    return;
                }
                _Number = value;
            }
        }
        public String SlotSpace
        {
            get { return _SlotSpace; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("SlotSpace field cant be empty");
                    return;
                }
                _SlotSpace = value;
            }
        }


    }
}
