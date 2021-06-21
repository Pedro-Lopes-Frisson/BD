using System;

namespace VirtualShopC.Objetos
{
    [Serializable()]
    public class buyerStash
    {
        public string ID;
        public string TypeCode;

        public buyerStash(string iD, string typeCode)
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
