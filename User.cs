using System;
using System.Security.Cryptography.X509Certificates;

namespace HotelApp
{
    public class Users //Class user
    {
        public string UserName {get; set; }
        public bool IsPersonal {get; set; }
        public string Password {get; set; } //Default password inte är ett måste pga gäst och personal
        public int Guests {get; set; }
        //Konstruktor till class users
        public Users(string username, bool ispersonal, string password, int guests)
        {
            UserName = username;
            IsPersonal = ispersonal;
            Password = password;
            Guests = guests;
        }










    }
            

        
    
         
            
        

}