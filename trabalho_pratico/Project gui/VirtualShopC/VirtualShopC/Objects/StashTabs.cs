namespace stashTabs
{
    [Serializable()]
    public class stashTabs
    {
        private String _Stash_ID;
        private String _Number;
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


    }
}
