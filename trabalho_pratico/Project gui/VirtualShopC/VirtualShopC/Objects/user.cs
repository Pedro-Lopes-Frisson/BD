using System;

namespace VirtualShopC.Objetos
{
    [Serializable()]
    public class User
    {
        public string Email;
        public string AccName;
        public string Pass;
        public string RealCurrency;
        public string GameCurrency;
        public string UserID;

        public User(string email, string accName, string pass, string realCurrency, string gameCurrency, string userID)
        {
            Email = email;
            AccName = accName;
            Pass = pass;
            RealCurrency = realCurrency;
            GameCurrency = gameCurrency;
            UserID = userID;
        }
        public override string ToString()
        {
            return  Email+ AccName+ Pass+ RealCurrency+ GameCurrency+ UserID;
        }
    }

}
