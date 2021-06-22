using System;

namespace VirtualShopC.objectos
{
    [Serializable()]
    public class normalTab
    {
        public string Stash_ID;
        public string Number;
        public string SlotSpace;

        public normalTab(string stash_ID, string number, string slotSpace)
        {
            Stash_ID = stash_ID;
            Number = number;
            SlotSpace = slotSpace;
        }

        public override string ToString()
        {
            return Stash_ID + Number + SlotSpace;
        }

    }
}
