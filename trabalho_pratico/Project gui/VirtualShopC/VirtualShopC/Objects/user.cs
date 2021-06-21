namespace user
{
    [Serializable()]
    public class user
    {
        private String _Email;
        private String _AccName;
        private String _Pass;
        private String _RealCurrency;
        private String _GameCurrency;
        private String _UserID;
        public String UserID
        {
            get { return _UserID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("UserID field cant be empty");
                    return;
                }
                _UserID = value;
            }
        }
        public String Email
        {
            get { return _Email; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Email field cant be empty");
                    return;
                }
                _Email = value;
            }
        }
        public String AccName
        {
            get { return _AccName; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("AccName field cant be empty");
                    return;
                }
                _AccName = value;
            }
        }
        public String Pass
        {
            get { return _Pass; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Pass field cant be empty");
                    return;
                }
                _Pass = value;
            }
        }
        public String RealCurrency
        {
            get { return _RealCurrency; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("RealCurrency field cant be empty");
                    return;
                }
                _RealCurrency = value;
            }
        }
        public String GameCurrency
        {
            get { return _GameCurrency; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("GameCurrency field cant be empty");
                    return;
                }
                _GameCurrency = value;
            }
        }

    }
}
