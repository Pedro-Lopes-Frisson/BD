using System;

namespace SpecialItem
{
    [Serializable()]
    public class specialItem
    {
        public String Name;
        public String Price;
        public String CurrencyType;
        public String Rank;
        public String ID;

        public specialItem(string name, string price, string currencyType, string rank, string iD)
        {
            Name = name;
            Price = price;
            CurrencyType = currencyType;
            Rank = rank;
            ID = iD;
        }
        public override string ToString()
        {
            return Name+ Price+ CurrencyType+ Rank+ ID;
        }
    }
}
