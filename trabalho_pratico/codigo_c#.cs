

namespace specialItem
{
[Serializable()]]
public class specialItem
{


private String _ID;
private String _Name;
private String _Price;
private String _CurrencyType;
private String _Rank;

 public String ID; {
  get { return _ID;}
  set { _ID = value; }
}
 public String Name; {
  get { return _Name;}
  set { _Name = value; }
}
 public String Price; {
  get { return _Price;}
  set { _Price = value; }
}
 public String CurrencyType; {
	get { return _CurrencyType; }
	set { _CurrencyType = value; }
}
 public String Rank; {
	get { return _Rank; }
	set { _Rank = value; }

}
}}




namespace consumable
{
[Serializable()]]
public class consumable
{

private String _SpecialItem_ID;
private String _Effect;
private String _Duration;
private String _Quantity;
 public String SpecialItem_ID; {
  get { return _SpecialItem_ID;}
  set { _SpecialItem_ID = value; }
}
 public String Effect; {
  get { return _Effect;}
  set { _Effect = value; }
}
 public String Duration; {
  get { return _Duration;}
  set { _Duration = value; }
}
 public String Quantity; {
  get { return _Quantity;}
  set { _Quantity = value; }
}



<



namespace cosmetic
{
[Serializable()]]
public class cosmetic
{

private String _SpecialItem_ID;
private String _Type;
private String _BodyPart;
private String _Gender;
 public String SpecialItem_ID; {
  get { return _SpecialItem_ID;}
  set { _SpecialItem_ID = value; }
 public String Type; {
  get { return _Type;}
  set { _Type = value; }
 public String BodyPart; {
  get { return _BodyPart;}
  set { _BodyPart = value; }
 public String Gender; {
  get { return _Gender;}
  set { _Gender = value; }


)



namespace user
{
[Serializable()]]
public class user
{

private String _UserID;
private String _Email;
private String _AccName;
private String _Pass;
private String _RealCurrency;
private String _GameCurrency;
 public String UserID; {
  get { return _UserID;}
  set { _UserID = value; }
 public String Email; {
  get { return _Email;}
  set { _Email = value; }
 public String AccName; {
  get { return _AccName;}
  set { _AccName = value; }
 public String Pass; {
  get { return _Pass;}
  set { _Pass = value; }
 public String RealCurrency; {
  get { return _RealCurrency;}
  set { _RealCurrency = value; }
 public String GameCurrency; {
  get { return _GameCurrency;}
  set { _GameCurrency = value; }

        )



namespace stash
{
[Serializable()]]
public class stash
{

private String _ID;
private String _User_ID;
private String _NumberOfTabs;
 public String ID; {
  get { return _ID;}
  set { _ID = value; }
 public String User_ID; {
  get { return _User_ID;}
  set { _User_ID = value; }
 public String NumberOfTabs; {
  get { return _NumberOfTabs;}
  set { _NumberOfTabs = value; }



)




namespace vendorStash
{
[Serializable()]]
public class vendorStash
{

private String _ID;
private String _TypeCode;
 public String ID; {
  get { return _ID;}
  set { _ID = value; }
 public String TypeCode; {
  get { return _TypeCode;}
  set { _TypeCode = value; }

  --CHECK(TypeCode LIKE 'vendor[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')

)



namespace buyerStash
{
[Serializable()]]
public class buyerStash
{

private String _ID;
private String _TypeCode;
 public String ID; {
  get { return _ID;}
  set { _ID = value; }
 public String TypeCode; {
  get { return _TypeCode;}
  set { _TypeCode = value; }

  --CHECK(TypeCode LIKE 'buyer[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')

)



namespace stashTabs
{
[Serializable()]]
public class stashTabs
{

private String _Stash_ID;
private String _Number;
 public String Stash_ID; {
  get { return _Stash_ID;}
  set { _Stash_ID = value; }
 public String Number; {
  get { return _Number;}
  set { _Number = value; }


)



namespace normalTab
{
[Serializable()]]
public class normalTab
{

private String _Stash_ID;
private String _Number;
private String _SlotSpace;
 public String Stash_ID; {
  get { return _Stash_ID;}
  set { _Stash_ID = value; }
 public String Number; {
  get { return _Number;}
  set { _Number = value; }
 public String SlotSpace; {
  get { return _SlotSpace;}
  set { _SlotSpace = value; }


)



namespace specialTab
{
[Serializable()]]
public class specialTab
{

private String _Stash_ID;
private String _Number;
private String _SlotSpace;
 public String Stash_ID; {
  get { return _Stash_ID;}
  set { _Stash_ID = value; }
 public String Number; {
  get { return _Number;}
  set { _Number = value; }
 public String SlotSpace; {
  get { return _SlotSpace;}
  set { _SlotSpace = value; }

)



namespace item
{
[Serializable()]]
public class item
{


private String _ID;
private String _Stash_ID;
private String _TabNumber;
private String _Price;
private String _Name;
private String _isUnique;
private String _Upgraded;
private String _Rank;

 public String ID; {
  get { return _ID;}
  set { _ID = value; }
 public String Stash_ID; {
  get { return _Stash_ID;}
  set { _Stash_ID = value; }
 public String TabNumber; {
  get { return _TabNumber;}
  set { _TabNumber = value; }

 public String Price; {
  get { return _Price;}
  set { _Price = value; }
 public String Name; {
  get { return _Name;}
  set { _Name = value; }
 public String isUnique; {
  get { return _isUnique;}
  set { _isUnique = value; }
 public String Upgraded; {
  get { return _Upgraded;}
  set { _Upgraded = value; }
 public String Rank; {
  get { return _Rank;}
  set { _Rank = value; }




)



namespace weapon
{
[Serializable()]]
public class weapon
{

private String _item_ID;
private String _SpecialAttributes;
private String _Damage;
private String _DamageType;
private String _CriticalChance;
private String _CriticalMutiplier;
private String _Price;
private String _Name;
private String _isUnique;
private String _Upgraded;
private String _Rank;
private String _TabNumber;
private String _Stash_ID;
 public String item_ID; {
  get { return _item_ID;}
  set { _item_ID = value; }
 public String SpecialAttributes; {
  get { return _SpecialAttributes;}
  set { _SpecialAttributes = value; }
 public String Damage; {
  get { return _Damage;}
  set { _Damage = value; }
 public String DamageType; {
  get { return _DamageType;}
  set { _DamageType = value; }
 public String CriticalChance; {
  get { return _CriticalChance;}
  set { _CriticalChance = value; }
 public String CriticalMutiplier; {
  get { return _CriticalMutiplier;}
  set { _CriticalMutiplier = value; }
	-- Item specifics
 public String Price; {
  get { return _Price;}
  set { _Price = value; }
 public String Name; {
  get { return _Name;}
  set { _Name = value; }
 public String isUnique; {
  get { return _isUnique;}
  set { _isUnique = value; }
 public String Upgraded; {
  get { return _Upgraded;}
  set { _Upgraded = value; }
 public String Rank; {
  get { return _Rank;}
  set { _Rank = value; }
 public String TabNumber; {
  get { return _TabNumber;}
  set { _TabNumber = value; }
 public String Stash_ID; {
  get { return _Stash_ID;}
  set { _Stash_ID = value; }






)



namespace ranged
{
[Serializable()]]
public class ranged
{

private String _item_ID;
private String _Range;
private String _Accuraccy;
private String _Price;
private String _Name;
private String _isUnique;
private String _Upgraded;
private String _Rank;
private String _TabNumber;
private String _Stash_ID;
private String _SpecialAttributes;
private String _Damage;
private String _DamageType;
private String _CriticalChance;
private String _CriticalMutiplier;
 public String item_ID; {
  get { return _item_ID;}
  set { _item_ID = value; }
 public String Range; {
  get { return _Range;}
  set { _Range = value; }
 public String Accuraccy; {
  get { return _Accuraccy;}
  set { _Accuraccy = value; }

	-- Item specifics
 public String Price; {
  get { return _Price;}
  set { _Price = value; }
 public String Name; {
  get { return _Name;}
  set { _Name = value; }
 public String isUnique; {
  get { return _isUnique;}
  set { _isUnique = value; }
 public String Upgraded; {
  get { return _Upgraded;}
  set { _Upgraded = value; }
 public String Rank; {
  get { return _Rank;}
  set { _Rank = value; }
 public String TabNumber; {
  get { return _TabNumber;}
  set { _TabNumber = value; }
 public String Stash_ID; {
  get { return _Stash_ID;}
  set { _Stash_ID = value; }
	-- weapon specifics
 public String SpecialAttributes; {
  get { return _SpecialAttributes;}
  set { _SpecialAttributes = value; }
 public String Damage; {
  get { return _Damage;}
  set { _Damage = value; }
 public String DamageType; {
  get { return _DamageType;}
  set { _DamageType = value; }
 public String CriticalChance; {
  get { return _CriticalChance;}
  set { _CriticalChance = value; }
 public String CriticalMutiplier; {
  get { return _CriticalMutiplier;}
  set { _CriticalMutiplier = value; }





)



namespace physical
{
[Serializable()]]
public class physical
{

private String _item_ID;
private String _PiercingRate;
private String _FireRate;
private String _Price;
private String _Name;
private String _isUnique;
private String _Upgraded;
private String _Rank;
private String _TabNumber;
private String _Stash_ID;
private String _SpecialAttributes;
private String _Damage;
private String _DamageType;
private String _CriticalChance;
private String _CriticalMutiplier;
private String _Range;
private String _Accuraccy;
 public String item_ID; {
  get { return _item_ID;}
  set { _item_ID = value; }
 public String PiercingRate; {
  get { return _PiercingRate;}
  set { _PiercingRate = value; }
 public String FireRate; {
  get { return _FireRate;}
  set { _FireRate = value; }

	-- Item specifics
 public String Price; {
  get { return _Price;}
  set { _Price = value; }
 public String Name; {
  get { return _Name;}
  set { _Name = value; }
 public String isUnique; {
  get { return _isUnique;}
  set { _isUnique = value; }
 public String Upgraded; {
  get { return _Upgraded;}
  set { _Upgraded = value; }
 public String Rank; {
  get { return _Rank;}
  set { _Rank = value; }
 public String TabNumber; {
  get { return _TabNumber;}
  set { _TabNumber = value; }
 public String Stash_ID; {
  get { return _Stash_ID;}
  set { _Stash_ID = value; }

	-- weapon specifics
 public String SpecialAttributes; {
  get { return _SpecialAttributes;}
  set { _SpecialAttributes = value; }
 public String Damage; {
  get { return _Damage;}
  set { _Damage = value; }
 public String DamageType; {
  get { return _DamageType;}
  set { _DamageType = value; }
 public String CriticalChance; {
  get { return _CriticalChance;}
  set { _CriticalChance = value; }
 public String CriticalMutiplier; {
  get { return _CriticalMutiplier;}
  set { _CriticalMutiplier = value; }

	-- ranged
 public String Range; {
  get { return _Range;}
  set { _Range = value; }
 public String Accuraccy; {
  get { return _Accuraccy;}
  set { _Accuraccy = value; }





)





namespace magical
{
[Serializable()]]
public class magical
{

private String _item_ID;
private String _CoolDown;
private String _RadiusOfEffectiveness;
private String _Price;
private String _Name;
private String _isUnique;
private String _Upgraded;
private String _Rank;
private String _TabNumber;
private String _Stash_ID;
private String _SpecialAttributes;
private String _Damage;
private String _DamageType;
private String _CriticalChance;
private String _CriticalMutiplier;
private String _Range;
private String _Accuraccy;

 public String item_ID; {
  get { return _item_ID;}
  set { _item_ID = value; }
 public String CoolDown; {
  get { return _CoolDown;}
  set { _CoolDown = value; }
 public String RadiusOfEffectiveness; {
  get { return _RadiusOfEffectiveness;}
  set { _RadiusOfEffectiveness = value; }
	-- Item specifics
 public String Price; {
  get { return _Price;}
  set { _Price = value; }
 public String Name; {
  get { return _Name;}
  set { _Name = value; }
 public String isUnique; {
  get { return _isUnique;}
  set { _isUnique = value; }
 public String Upgraded; {
  get { return _Upgraded;}
  set { _Upgraded = value; }
 public String Rank; {
  get { return _Rank;}
  set { _Rank = value; }
 public String TabNumber; {
  get { return _TabNumber;}
  set { _TabNumber = value; }
 public String Stash_ID; {
  get { return _Stash_ID;}
  set { _Stash_ID = value; }
	-- weapon specifics
 public String SpecialAttributes; {
  get { return _SpecialAttributes;}
  set { _SpecialAttributes = value; }
 public String Damage; {
  get { return _Damage;}
  set { _Damage = value; }
 public String DamageType; {
  get { return _DamageType;}
  set { _DamageType = value; }
 public String CriticalChance; {
  get { return _CriticalChance;}
  set { _CriticalChance = value; }
 public String CriticalMutiplier; {
  get { return _CriticalMutiplier;}
  set { _CriticalMutiplier = value; }
	-- ranged
 public String Range; {
  get { return _Range;}
  set { _Range = value; }
 public String Accuraccy; {
  get { return _Accuraccy;}
  set { _Accuraccy = value; }





)




namespace melee
{
[Serializable()]]
public class melee
{

private String _Weapon_ID;
private String _AttackSpeed;
private String _HandNum;
private String _MeleeType;
private String _Price;
private String _Name;
private String _isUnique;
private String _Upgraded;
private String _Rank;
private String _TabNumber;
private String _Stash_ID;
private String _SpecialAttributes;
private String _Damage;
private String _DamageType;
private String _CriticalChance;
private String _CriticalMutiplier;
 public String Weapon_ID; {
  get { return _Weapon_ID;}
  set { _Weapon_ID = value; }
 public String AttackSpeed; {
  get { return _AttackSpeed;}
  set { _AttackSpeed = value; }
 public String HandNum; {
  get { return _HandNum;}
  set { _HandNum = value; }
 public String MeleeType; {
  get { return _MeleeType;}
  set { _MeleeType = value; }
	-- Item specifics
 public String Price; {
  get { return _Price;}
  set { _Price = value; }
 public String Name; {
  get { return _Name;}
  set { _Name = value; }
 public String isUnique; {
  get { return _isUnique;}
  set { _isUnique = value; }
 public String Upgraded; {
  get { return _Upgraded;}
  set { _Upgraded = value; }
 public String Rank; {
  get { return _Rank;}
  set { _Rank = value; }
 public String TabNumber; {
  get { return _TabNumber;}
  set { _TabNumber = value; }
 public String Stash_ID; {
  get { return _Stash_ID;}
  set { _Stash_ID = value; }
	-- weapon specifics
 public String SpecialAttributes; {
  get { return _SpecialAttributes;}
  set { _SpecialAttributes = value; }
 public String Damage; {
  get { return _Damage;}
  set { _Damage = value; }
 public String DamageType; {
  get { return _DamageType;}
  set { _DamageType = value; }
 public String CriticalChance; {
  get { return _CriticalChance;}
  set { _CriticalChance = value; }
 public String CriticalMutiplier; {
  get { return _CriticalMutiplier;}
  set { _CriticalMutiplier = value; }






)



namespace armor
{
[Serializable()]]
public class armor
{


private String _ID;
private String _SpecialAttributes;
private String _Defense;
private String _HealthBonus;
private String _Price;
private String _Name;
private String _isUnique;
private String _Upgraded;
private String _Rank;
private String _TabNumber;
private String _Stash_ID;
 public String ID; {
  get { return _ID;}
  set { _ID = value; }
 public String SpecialAttributes; {
  get { return _SpecialAttributes;}
  set { _SpecialAttributes = value; }
 public String Defense; {
  get { return _Defense;}
  set { _Defense = value; }
 public String HealthBonus; {
  get { return _HealthBonus;}
  set { _HealthBonus = value; }
	-- Item specifics
 public String Price; {
  get { return _Price;}
  set { _Price = value; }
 public String Name; {
  get { return _Name;}
  set { _Name = value; }
 public String isUnique; {
  get { return _isUnique;}
  set { _isUnique = value; }
 public String Upgraded; {
  get { return _Upgraded;}
  set { _Upgraded = value; }
 public String Rank; {
  get { return _Rank;}
  set { _Rank = value; }
 public String TabNumber; {
  get { return _TabNumber;}
  set { _TabNumber = value; }
 public String Stash_ID; {
  get { return _Stash_ID;}
  set { _Stash_ID = value; }





}


namespace shield
{
[Serializable()]]
public class shield
{


private String _ID;
private String _Defense;
private String _SpecialAbility;
private String _Price;
private String _Name;
private String _isUnique;
private String _Upgraded;
private String _Rank;
private String _TabNumber;
private String _Stash_ID;

 public String ID; {
  get { return _ID;}
  set { _ID = value; }
 public String Defense; {
  get { return _Defense;}
  set { _Defense = value; }
 public String SpecialAbility; {
  get { return _SpecialAbility;}
  set { _SpecialAbility = value; }
	-- Item specifics
 public String Price; {
  get { return _Price;}
  set { _Price = value; }
 public String Name; {
  get { return _Name;}
  set { _Name = value; }
 public String isUnique; {
  get { return _isUnique;}
  set { _isUnique = value; }
 public String Upgraded; {
  get { return _Upgraded;}
  set { _Upgraded = value; }
 public String Rank; {
  get { return _Rank;}
  set { _Rank = value; }
 public String TabNumber; {
  get { return _TabNumber;}
  set { _TabNumber = value; }
 public String Stash_ID; {
  get { return _Stash_ID;}
  set { _Stash_ID = value; }


  }
