namespace buyerStash
{
    [Serializable()]
    public class buyerStash
    {
        private String _ID;
        private String _TypeCode;
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

        public String TypeCode
        {
            get { return _TypeCode; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("TypeCode field cant be empty");
                    return;
                }
                _TypeCode = value;
            }
        }



    }
}
