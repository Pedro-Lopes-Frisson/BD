using System;

namespace VirtualShopC.Objetos
{
    [Serializable()]
    public class Cosmetic
    {
        public string SpecialItem_ID;
        public string Type;
        public string BodyPart;
        public string Gender;

        public Cosmetic(string specialItem_ID, string type, string bodyPart, string gender)
        {
            SpecialItem_ID = specialItem_ID;
            Type = type;
            BodyPart = bodyPart;
            Gender = gender;
        }
        public override string ToString()
        {
            return SpecialItem_ID+ Type+ BodyPart+ Gender;
        }
    }
}
