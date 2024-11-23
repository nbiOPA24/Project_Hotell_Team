using System;
using System.Security.Cryptography.X509Certificates;

namespace HotelApp
{
    public class User //Class user
    {
        public string UserName {get; set; } // Name of the user
        public bool IsPersonal {get; set; } // Whether the user is staff
        public string Password {get; set; } // Password for login
        public int Guests {get; set; } // Number of guests for booking
        // Constructor for User
        public User(string username, bool ispersonal, string password)
        {
            UserName = username;
            IsPersonal = ispersonal;
            Password = password;
          
        }

        public User(string username, bool ispersonal, string password, int guests)
        {
            UserName = username;
            IsPersonal = ispersonal;
            Password = password;
            Guests = guests;
        }
    }
}








            

        
    
         
            
        
