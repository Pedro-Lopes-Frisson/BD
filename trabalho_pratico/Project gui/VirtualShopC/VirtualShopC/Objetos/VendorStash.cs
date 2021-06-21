using System;

namespace VirtualShopC.Objetos
{
    [Serializable()]
    public class VendorStash
    {
        public string ID;
        public string TypeCode;

        public VendorStash(string iD, string typeCode)
        {
            ID = iD;
            TypeCode = typeCode;
        }

        public override string ToString()
        {
            return  ID+ TypeCode;
        }
    }
}
