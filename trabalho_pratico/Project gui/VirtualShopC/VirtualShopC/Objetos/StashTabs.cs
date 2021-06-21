using System;

namespace VirtualShopC.Objetos
{

    [Serializable()]
    public class StashTabs
    {
        public string Stash_ID;
        public string Number;

        public StashTabs(string stash_ID, string number)
        {
            Stash_ID = stash_ID;
            Number = number;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Stash_ID + Number;
        }
    }
}
