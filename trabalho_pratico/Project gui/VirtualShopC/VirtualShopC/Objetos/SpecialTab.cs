using System;

namespace VirtualShopC.Objetos
{
    [Serializable()]
    public class SpecialTab
    {
        public string Stash_ID;
        public string Number;
        public string SlotSpace;

        public SpecialTab(string stash_ID, string number, string slotSpace)
        {
            Stash_ID = stash_ID;
            Number = number;
            SlotSpace = slotSpace;
        }
        public override string ToString()
        {
            return Stash_ID+ Number+ SlotSpace;
        }
    }
}
