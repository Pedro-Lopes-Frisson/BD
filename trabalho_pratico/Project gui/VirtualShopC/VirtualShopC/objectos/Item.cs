using System;

namespace VirtualShopC.Objetos
{
    [Serializable()]
    public class Item
    {

        public string TabNumber;
        public string Price;
        public string Name;
        public string isUnique;
        public string Upgraded;
        public string Rank;
        public string ID;
        public string Stash_ID;

        public Item(string tabNumber, string price, string name, string isUnique, string upgraded, string rank, string iD, string stash_ID)
        {
            TabNumber = tabNumber;
            Price = price;
            Name = name;
            this.isUnique = isUnique;
            Upgraded = upgraded;
            Rank = rank;
            ID = iD;
            Stash_ID = stash_ID;
        }
        public Item() { }
        public override string ToString()
        {
            return Rank + " " + Name + " +" + Upgraded;
        }
    }
}
