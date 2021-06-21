namespace cosmetic
{
    [Serializable()]
    public class cosmetic
    {
        private String _SpecialItem_ID;
        private String _Type;
        private String _BodyPart;
        private String _Gender;
        public String SpecialItem_ID
        {
            get { return _SpecialItem_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("SpecialItem_ID field cant be empty");
                    return;
                }
                _SpecialItem_ID = value;
            }
        }
        public String Type
        {
            get { return _Type; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Type field cant be empty");
                    return;
                }
                _Type = value;
            }
        }
        public String BodyPart
        {
            get { return _BodyPart; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("BodyPart field cant be empty");
                    return;
                }
                _BodyPart = value;
            }
        }
        public String Gender
        {
            get { return _Gender; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Gender field cant be empty");
                    return;
                }
                _Gender = value;
            }
        }


    }
}
