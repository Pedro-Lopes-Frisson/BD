using System;

namespace VirtualShopC.Objetos
{
    [Serializable()]
    public class Stash
    {
        public string ID;
        public string User_ID;
        public string NumberOfTabs;

        public Stash(string iD, string user_ID, string numberOfTabs)
        {
            ID = iD;
            User_ID = user_ID;
            NumberOfTabs = numberOfTabs;
        }

        public override string ToString()
        {
            return ID+ User_ID+ NumberOfTabs;
        }
    }
}
