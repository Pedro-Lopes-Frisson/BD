namespace specialItem
{
    [Serializable()]
    public class specialItem
    {
        private String _ID;
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
        private String _Name;
        public String Name
        {
            get { return _Name; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Name field cant be empty");
                    return;
                }
                _Name = value;
            }
        }
        private String _Price;
        public String Price
        {
            get { return _Price; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Price field cant be empty");
                    return;
                }
                _Price = value;
            }
        }
        private String _CurrencyType;
        public String CurrencyType
        {
            get { return _CurrencyType; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CurrencyType field cant be empty");
                    return;
                }
                _CurrencyType = value;
            }
        }
        private String _Rank;
        public String Rank
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CurrencyType field cant be empty");
                    return;
                }
            }
        }
    }
}

namespace consumable
{
    [Serializable()]
    public class consumable
    {
        private String _SpecialItem_ID;
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
        private String _Effect;
        public String Effect
        {
            get { return _Effect; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Effect field cant be empty");
                    return;
                }
                _Effect = value;
            }
        }
        private String _Duration;
        public String Duration
        {
            get { return _Duration; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Duration field cant be empty");
                    return;
                }
                _Duration = value;
            }
        }
        private String _Quantity;
        public String Quantity
        {
            get { return _Quantity; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Quantity field cant be empty");
                    return;
                }
                _Quantity = value;
            }
        }



    }
}

namespace cosmetic
{
    [Serializable()]
    public class cosmetic
    {
        private String _SpecialItem_ID;
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
        private String _Type;
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
        private String _BodyPart;
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
        private String _Gender;
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

namespace user
{
    [Serializable()]
    public class user
    {
        private String _UserID;
        public String UserID
        {
            get { return _UserID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("UserID field cant be empty");
                    return;
                }
                _UserID = value;
            }
        }
        private String _Email;
        public String Email
        {
            get { return _Email; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Email field cant be empty");
                    return;
                }
                _Email = value;
            }
        }
        private String _AccName;
        public String AccName
        {
            get { return _AccName; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("AccName field cant be empty");
                    return;
                }
                _AccName = value;
            }
        }
        private String _Pass;
        public String Pass
        {
            get { return _Pass; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Pass field cant be empty");
                    return;
                }
                _Pass = value;
            }
        }
        private String _RealCurrency;
        public String RealCurrency
        {
            get { return _RealCurrency; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("RealCurrency field cant be empty");
                    return;
                }
                _RealCurrency = value;
            }
        }
        private String _GameCurrency;
        public String GameCurrency
        {
            get { return _GameCurrency; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("GameCurrency field cant be empty");
                    return;
                }
                _GameCurrency = value;
            }
        }

    }
}

namespace stash
{
    [Serializable()]
    public class stash
    {
        private String _ID;
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
        private String _User_ID;
        public String User_ID
        {
            get { return _User_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("User_ID field cant be empty");
                    return;
                }
                _User_ID = value;
            }
        }
        private String _NumberOfTabs;
        public String NumberOfTabs
        {
            get { return _NumberOfTabs; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("NumberOfTabs field cant be empty");
                    return;
                }
                _NumberOfTabs = value;
            }
        }
        private String _CHECK;
        public String CHECK
        {
            get { return _CHECK; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CHECK field cant be empty");
                    return;
                }
                _CHECK = value;
            }
        }



    }
}

namespace vendorStash
{
    [Serializable()]
    public class vendorStash
    {
        private String _ID;
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
        private String _TypeCode;
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

namespace buyerStash
{
    [Serializable()]
    public class buyerStash
    {
        private String _ID;
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

        private String _TypeCode;
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

namespace stashTabs
{
    [Serializable()]
    public class stashTabs
    {
        private String _Stash_ID;
        public String Stash_ID
        {
            get { return _Stash_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Stash_ID field cant be empty");
                    return;
                }
                _Stash_ID = value;
            }
        }
        private String _Number;
        public String Number
        {
            get { return _Number; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Number field cant be empty");
                    return;
                }
                _Number = value;
            }
        }


    }
}

namespace normalTab
{
    [Serializable()]
    public class normalTab
    {
        private String _Stash_ID;
        public String Stash_ID
        {
            get { return _Stash_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Stash_ID field cant be empty");
                    return;
                }
                _Stash_ID = value;
            }
        }
        private String _Number;
        public String Number
        {
            get { return _Number; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Number field cant be empty");
                    return;
                }
                _Number = value;
            }
        }
        private String _SlotSpace;
        public String SlotSpace
        {
            get { return _SlotSpace; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("SlotSpace field cant be empty");
                    return;
                }
                _SlotSpace = value;
            }
        }


    }
}

namespace specialTab
{
    [Serializable()]
    public class specialTab
    {
        private String _Stash_ID;
        public String Stash_ID
        {
            get { return _Stash_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Stash_ID field cant be empty");
                    return;
                }
                _Stash_ID = value;
            }
        }
        private String _Number;
        public String Number
        {
            get { return _Number; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Number field cant be empty");
                    return;
                }
                _Number = value;
            }
        }
        private String _SlotSpace;
        public String SlotSpace
        {
            get { return _SlotSpace; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("SlotSpace field cant be empty");
                    return;
                }
                _SlotSpace = value;
            }
        }

    }
}

namespace item
{
    [Serializable()]
    public class item
    {

        private String _ID;
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
        private String _Stash_ID;
        public String Stash_ID
        {
            get { return _Stash_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Stash_ID field cant be empty");
                    return;
                }
                _Stash_ID = value;
            }
        }
        private String _TabNumber;
        public String TabNumber
        {
            get { return _TabNumber; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("TabNumber field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }

        private String _Price;
        public String Price
        {
            get { return _Price; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Price field cant be empty");
                    return;
                }
                _Price = value;
            }
        }
        private String _Name;
        public String Name
        {
            get { return _Name; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Name field cant be empty");
                    return;
                }
                _Name = value;
            }
        }
        private String _isUnique;
        public String isUnique
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("isUniquefield cant be empty");
                    return;
                }
                _isUnique = value;
            }
        }

        private String _Upgraded;
        public String Upgraded
        {
            get { return _Upgraded; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Upgraded field cant be empty");
                    return;
                }
                _Upgraded = value;
            }
        }
        private String _Rank;
        public String Rank
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Rank field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
    }
}

namespace weapon
{
    [Serializable()]
    public class weapon
    {
        private String _item_ID;
        public String item_ID
        {
            get { return _item_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("item_ID field cant be empty");
                    return;
                }
                _item_ID = value;
            }
        }
        private String _SpecialAttributes;
        public String SpecialAttributes
        {
            get { return _SpecialAttributes; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("SpecialAttributes field cant be empty");
                    return;
                }
                _SpecialAttributes = value;
            }
        }
        private String _Damage;
        public String Damage
        {
            get { return _Damage; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Damage field cant be empty");
                    return;
                }
                _Damage = value;
            }
        }
        private String _DamageType;
        public String DamageType
        {
            get { return _DamageType; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("DamageType field cant be empty");
                    return;
                }
                _DamageType = value;
            }
        }
        private String _CriticalChance;
        public String CriticalChance
        {
            get { return _CriticalChance; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CriticalChance field cant be empty");
                    return;
                }
                _CriticalChance = value;
            }
        }
        private String _CriticalMutiplier;
        public String CriticalMutiplier
        {
            get { return _CriticalMutiplier; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CriticalMutiplier field cant be empty");
                    return;
                }
                _CriticalMutiplier = value;
            }
        }

        private String _Price;
        public String Price
        {
            get { return _Price; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Price field cant be empty");
                    return;
                }
                _Price = value;
            }
        }
        private String _Name;
        public String Name
        {
            get { return _Name; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Name field cant be empty");
                    return;
                }
                _Name = value;
            }
        }
        private String _isUnique;
        public String isUnique
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("isUniquefield cant be empty");
                    return;
                }
                _isUnique = value;
            }
        }
        private String _Upgraded;
        public String Upgraded
        {
            get { return _Upgraded; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Upgraded field cant be empty");
                    return;
                }
                _Upgraded = value;
            }
        }
        private String _Rank;
        public String Rank
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Rank field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        private String _TabNumber;
        public String TabNumber
        {
            get { return _TabNumber; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("TabNumber field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        private String _Stash_ID;
        public String Stash_ID
        {
            get { return _Stash_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Stash_ID field cant be empty");
                    return;
                }
                _Stash_ID = value;
            }
        }



        private String _CHECK;
        public String CHECK
        {
            get { return _CHECK; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CHECK field cant be empty");
                    return;
                }
                _CHECK = value;
            }
        }



    }
}

namespace ranged
{
    [Serializable()]
    public class ranged
    {

        private String _item_ID;
        public String item_ID
        {
            get { return _item_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Range field cant be empty");
                    return;
                }
                _item_ID = value;
            }
        }
        private String _Range;
        public String Range
        {
            get { return _Range; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Range field cant be empty");
                    return;
                }
                _Range = value;
            }
        }
        private String _Accuraccy;
        public String Accuraccy
        {
            get { return _Accuraccy; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Accuraccy field cant be empty");
                    return;
                }
                _Accuraccy = value;
            }
        }

        private String _Price;
        public String Price
        {
            get { return _Price; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Price field cant be empty");
                    return;
                }
                _Price = value;
            }
        }
        private String _Name;
        public String Name
        {
            get { return _Name; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Name field cant be empty");
                    return;
                }
                _Name = value;
            }
        }
        private String _isUnique;
        public String isUnique
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("isUniquefield cant be empty");
                    return;
                }
                _isUnique = value;
            }
        }
        private String _Upgraded;
        public String Upgraded
        {
            get { return _Upgraded; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Upgraded field cant be empty");
                    return;
                }
                _Upgraded = value;
            }
        }
        private String _Rank;
        public String Rank
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Rank field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        private String _TabNumber;
        public String TabNumber
        {
            get { return _TabNumber; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("TabNumber field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        private String _Stash_ID;
        public String Stash_ID
        {
            get { return _Stash_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Stash_ID field cant be empty");
                    return;
                }
                _Stash_ID = value;
            }
        }
        private String _SpecialAttributes;
        public String SpecialAttributes
        {
            get { return _SpecialAttributes; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("SpecialAttributes field cant be empty");
                    return;
                }
                _SpecialAttributes = value;
            }
        }
        private String _Damage;
        public String Damage
        {
            get { return _Damage; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Damage field cant be empty");
                    return;
                }
                _Damage = value;
            }
        }
        private String _DamageType;
        public String DamageType
        {
            get { return _DamageType; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("DamageType field cant be empty");
                    return;
                }
                _DamageType = value;
            }
        }
        private String _CriticalChance;
        public String CriticalChance
        {
            get { return _CriticalChance; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CriticalChance field cant be empty");
                    return;
                }
                _CriticalChance = value;
            }
        }
        private String _CriticalMutiplier;
        public String CriticalMutiplier
        {
            get { return _CriticalMutiplier; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CriticalMutiplier field cant be empty");
                    return;
                }
                _CriticalMutiplier = value;
            }
        }


    }
}

namespace physical
{
    [Serializable()]
    public class physical
    {
        private String _item_ID;
        public String item_ID
        {
            get { return _item_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Range field cant be empty");
                    return;
                }
                _item_ID = value;
            }
        }
        private String _PiercingRate;
        public String PiercingRate
        {
            get { return _PiercingRate; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("PiercingRate field cant be empty");
                    return;
                }
                _PiercingRate = value;
            }
        }
        private String _FireRate;
        public String FireRate
        {
            get { return _FireRate; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("FireRate field cant be empty");
                    return;
                }
                _FireRate = value;
            }
        }


        private String _Price;
        public String Price
        {
            get { return _Price; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Price field cant be empty");
                    return;
                }
                _Price = value;
            }
        }
        private String _Name;
        public String Name
        {
            get { return _Name; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Name field cant be empty");
                    return;
                }
                _Name = value;
            }
        }
        private String _isUnique;
        public String isUnique
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("isUniquefield cant be empty");
                    return;
                }
                _isUnique = value;
            }
        }
        private String _Upgraded;
        public String Upgraded
        {
            get { return _Upgraded; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Upgraded field cant be empty");
                    return;
                }
                _Upgraded = value;
            }
        }
        private String _Rank;
        public String Rank
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Rank field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        private String _TabNumber;
        public String TabNumber
        {
            get { return _TabNumber; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("TabNumber field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        private String _Stash_ID;
        public String Stash_ID
        {
            get { return _Stash_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Stash_ID field cant be empty");
                    return;
                }
                _Stash_ID = value;
            }
        }


        private String _SpecialAttributes;
        public String SpecialAttributes
        {
            get { return _SpecialAttributes; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("SpecialAttributes field cant be empty");
                    return;
                }
                _SpecialAttributes = value;
            }
        }
        private String _Damage;
        public String Damage
        {
            get { return _Damage; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Damage field cant be empty");
                    return;
                }
                _Damage = value;
            }
        }
        private String _DamageType;
        public String DamageType
        {
            get { return _DamageType; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("DamageType field cant be empty");
                    return;
                }
                _DamageType = value;
            }
        }
        private String _CriticalChance;
        public String CriticalChance
        {
            get { return _CriticalChance; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CriticalChance field cant be empty");
                    return;
                }
                _CriticalChance = value;
            }
        }
        private String _CriticalMutiplier;
        public String CriticalMutiplier
        {
            get { return _CriticalMutiplier; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CriticalMutiplier field cant be empty");
                    return;
                }
                _CriticalMutiplier = value;
            }
        }


        private String _Range;
        public String Range
        {
            get { return _Range; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Range field cant be empty");
                    return;
                }
                _Range = value;
            }
        }
        private String _Accuraccy;
        public String Accuraccy
        {
            get { return _Accuraccy; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Accuraccy field cant be empty");
                    return;
                }
                _Accuraccy = value;
            }
        }



    }
}

namespace magical
{
    [Serializable()]
    public class magical
    {
        private String _item_ID;
        public String item_ID
        {
            get { return _item_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Range field cant be empty");
                    return;
                }
                _item_ID = value;
            }
        }
        private String _CoolDown;
        public String CoolDown
        {
            get { return _CoolDown; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CoolDown field cant be empty");
                    return;
                }
                _CoolDown = value;
            }
        }
        private String _RadiusOfEffectiveness;
        public String RadiusOfEffectiveness
        {
            get { return _RadiusOfEffectiveness; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("RadiusOfEffectiveness field cant be empty");
                    return;
                }
                _RadiusOfEffectiveness = value;
            }
        }

        private String _Price;
        public String Price
        {
            get { return _Price; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Price field cant be empty");
                    return;
                }
                _Price = value;
            }
        }
        private String _Name;
        public String Name
        {
            get { return _Name; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Name field cant be empty");
                    return;
                }
                _Name = value;
            }
        }
        private String _isUnique;
        public String isUnique
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("isUniquefield cant be empty");
                    return;
                }
                _isUnique = value;
            }
        }
        private String _Upgraded;
        public String Upgraded
        {
            get { return _Upgraded; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Upgraded field cant be empty");
                    return;
                }
                _Upgraded = value;
            }
        }
        private String _Rank;
        public String Rank
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Rank field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        private String _TabNumber;
        public String TabNumber
        {
            get { return _TabNumber; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("TabNumber field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        private String _Stash_ID;
        public String Stash_ID
        {
            get { return _Stash_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Stash_ID field cant be empty");
                    return;
                }
                _Stash_ID = value;
            }
        }

        private String _SpecialAttributes;
        public String SpecialAttributes
        {
            get { return _SpecialAttributes; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("SpecialAttributes field cant be empty");
                    return;
                }
                _SpecialAttributes = value;
            }
        }
        private String _Damage;
        public String Damage
        {
            get { return _Damage; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Damage field cant be empty");
                    return;
                }
                _Damage = value;
            }
        }
        private String _DamageType;
        public String DamageType
        {
            get { return _DamageType; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("DamageType field cant be empty");
                    return;
                }
                _DamageType = value;
            }
        }
        private String _CriticalChance;
        public String CriticalChance
        {
            get { return _CriticalChance; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CriticalChance field cant be empty");
                    return;
                }
                _CriticalChance = value;
            }
        }
        private String _CriticalMutiplier;
        public String CriticalMutiplier
        {
            get { return _CriticalMutiplier; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CriticalMutiplier field cant be empty");
                    return;
                }
                _CriticalMutiplier = value;
            }
        }

        private String _Range;
        public String Range
        {
            get { return _Range; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Range field cant be empty");
                    return;
                }
                _Range = value;
            }
        }
        private String _Accuraccy;
        public String Accuraccy
        {
            get { return _Accuraccy; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Accuraccy field cant be empty");
                    return;
                }
                _Accuraccy = value;
            }
        }

        private String _CHECK;
        public String CHECK
        {
            get { return _CHECK; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CHECK field cant be empty");
                    return;
                }
                _CHECK = value;
            }
        }

        private String _CHECK;
        public String CHECK
        {
            get { return _CHECK; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CHECK field cant be empty");
                    return;
                }
                _CHECK = value;
            }
        }



    }
}

namespace melee
{
    [Serializable()]
    public class melee
    {
        private String _Weapon_ID;
        public String Weapon_ID
        {
            get { return _Weapon_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Weapon_ID field cant be empty");
                    return;
                }
                _Weapon_ID = value;
            }
        }
        private String _AttackSpeed;
        public String AttackSpeed
        {
            get { return _AttackSpeed; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("AttackSpeed field cant be empty");
                    return;
                }
                _AttackSpeed = value;
            }
        }
        private String _HandNum;
        public String HandNum
        {
            get { return _HandNum; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("HandNum field cant be empty");
                    return;
                }
                _HandNum = value;
            }
        }
        private String _MeleeType;
        public String MeleeType
        {
            get { return _MeleeType; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("MeleeType field cant be empty");
                    return;
                }
                _MeleeType = value;
            }
        }

        private String _Price;
        public String Price
        {
            get { return _Price; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Price field cant be empty");
                    return;
                }
                _Price = value;
            }
        }
        private String _Name;
        public String Name
        {
            get { return _Name; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Name field cant be empty");
                    return;
                }
                _Name = value;
            }
        }
        private String _isUnique;
        public String isUnique
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("isUniquefield cant be empty");
                    return;
                }
                _isUnique = value;
            }
        }
        private String _Upgraded;
        public String Upgraded
        {
            get { return _Upgraded; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Upgraded field cant be empty");
                    return;
                }
                _Upgraded = value;
            }
        }
        private String _Rank;
        public String Rank
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Rank field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        private String _TabNumber;
        public String TabNumber
        {
            get { return _TabNumber; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("TabNumber field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        private String _Stash_ID;
        public String Stash_ID
        {
            get { return _Stash_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Stash_ID field cant be empty");
                    return;
                }
                _Stash_ID = value;
            }
        }

        private String _SpecialAttributes;
        public String SpecialAttributes
        {
            get { return _SpecialAttributes; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("SpecialAttributes field cant be empty");
                    return;
                }
                _SpecialAttributes = value;
            }
        }

        private String _Damage;
        public String Damage
        {
            get { return _Damage; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Damage field cant be empty");
                    return;
                }
                _Damage = value;
            }
        }
        private String _DamageType;
        public String DamageType
        {
            get { return _DamageType; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("DamageType field cant be empty");
                    return;
                }
                _DamageType = value;
            }
        }
        private String _CriticalChance;
        public String CriticalChance
        {
            get { return _CriticalChance; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CriticalChance field cant be empty");
                    return;
                }
                _CriticalChance = value;
            }
        }
        private String _CriticalMutiplier;
        public String CriticalMutiplier
        {
            get { return _CriticalMutiplier; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CriticalMutiplier field cant be empty");
                    return;
                }
                _CriticalMutiplier = value;
            }
        }

        private String _CHECK;
        public String CHECK
        {
            get { return _CHECK; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CHECK field cant be empty");
                    return;
                }
                _CHECK = value;
            }
        }

        private String _CHECK;
        public String CHECK
        {
            get { return _CHECK; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CHECK field cant be empty");
                    return;
                }
                _CHECK = value;
            }
        }




    }
}

namespace armor
{
    [Serializable()]
    public class armor
    {

        private String _ID;
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

        private String _SpecialAttributes;
        public String SpecialAttributes
        {
            get { return _SpecialAttributes; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("SpecialAttributes field cant be empty");
                    return;
                }
                _SpecialAttributes = value;
            }
        }

        private String _Defense;
        public String Defense
        {
            get { return _Defense; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Defense field cant be empty");
                    return;
                }
                _Defense = value;
            }
        }
        private String _HealthBonus;
        public String HealthBonus
        {
            get { return _HealthBonus; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("HealthBonus field cant be empty");
                    return;
                }
                _HealthBonus = value;
            }
        }


        private String _Price;
        public String Price
        {
            get { return _Price; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Price field cant be empty");
                    return;
                }
                _Price = value;
            }
        }
        private String _Name;
        public String Name
        {
            get { return _Name; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Name field cant be empty");
                    return;
                }
                _Name = value;
            }
        }
        private String _isUnique;
        public String isUnique
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("isUniquefield cant be empty");
                    return;
                }
                _isUnique = value;
            }
        }
        private String _Upgraded;
        public String Upgraded
        {
            get { return _Upgraded; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Upgraded field cant be empty");
                    return;
                }
                _Upgraded = value;
            }
        }
        private String _Rank;
        public String Rank
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Rank field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }

        private String _TabNumber;
        public String TabNumber
        {
            get { return _TabNumber; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("TabNumber field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        private String _Stash_ID;
        public String Stash_ID
        {
            get { return _Stash_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Stash_ID field cant be empty");
                    return;
                }
                _Stash_ID = value;
            }
        }

        private String _CHECK;
        public String CHECK
        {
            get { return _CHECK; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CHECK field cant be empty");
                    return;
                }
                _CHECK = value;
            }
        }
        private String _CHECK;
        public String CHECK
        {
            get { return _CHECK; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("CHECK field cant be empty");
                    return;
                }
                _CHECK = value;
            }
        }


    }
}

namespace shield
{
    [Serializable()]
    public class shield
    {

        private String _ID;
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

        private String _Defense;
        public String Defense
        {
            get { return _Defense; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Defense field cant be empty");
                    return;
                }
                _Defense = value;
            }
        }
        private String _SpecialAbility;
        public String SpecialAbility
        {
            get { return _SpecialAbility; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("SpecialAbility field cant be empty");
                    return;
                }
                _SpecialAbility = value;
            }
        }

        private String _Price;
        public String Price
        {
            get { return _Price; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Price field cant be empty");
                    return;
                }
                _Price = value;
            }
        }
        private String _Name;
        public String Name
        {
            get { return _Name; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Name field cant be empty");
                    return;
                }
                _Name = value;
            }
        }
        private String _isUnique;
        public String isUnique
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("isUniquefield cant be empty");
                    return;
                }
                _isUnique = value;
            }
        }
        private String _Upgraded;
        public String Upgraded
        {
            get { return _Upgraded; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Upgraded field cant be empty");
                    return;
                }
                _Upgraded = value;
            }
        }
        private String _Rank;
        public String Rank
        {
            get { return _Rank; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Rank field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        private String _TabNumber;
        public String TabNumber
        {
            get { return _TabNumber; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("TabNumber field cant be empty");
                    return;
                }
                _TabNumber = value;
            }
        }
        private String _Stash_ID;
        public String Stash_ID
        {
            get { return _Stash_ID; }
            set
            {
                if (value == null | String.IsNullorEmpty(value))
                {
                    throw new Exception("Stash_ID field cant be empty");
                    return;
                }
                _Stash_ID = value;
            }
        }

    }
}


