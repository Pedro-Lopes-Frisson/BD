namespace stash
{
    [Serializable()]
    public class stash
    {
        private String _ID;
        private String _User_ID;
        private String _NumberOfTabs;
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
        public String User_ID
        {
            get { return _User_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("User_ID field cant be empty");
                    return;
                }
                _User_ID = value;
            }
        }
        public String NumberOfTabs
        {
            get { return _NumberOfTabs; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("NumberOfTabs field cant be empty");
                    return;
                }
                _NumberOfTabs = value;
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
