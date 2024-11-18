using System;

namespace HotelApp
{
    public class UI
    {
        public bool IsEmployee { get; private set; } 

        
        public void Login() //Tillfällig placeholder login
        {
            Console.WriteLine("Welcome to the Hotel Management System");
            Console.Write("Are you an employee? (y/n): ");
            string input = Console.ReadLine();

            IsEmployee = input.ToLower() == "y";
            Console.WriteLine(IsEmployee ? "Login successful! Welcome, Employee.\n" : "Login successful! Welcome, Guest.\n");
        }

        
        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Hotel Management System - Main Menu");
            Console.WriteLine("1. Option 1 (Lista över rum)");
            Console.WriteLine("2. Option 2 (Användarnamn lista)");
            Console.WriteLine("3. Option 3 (Placeholder)");
            Console.WriteLine("4. Option 3 Lista över review ");
            Console.WriteLine("5. Logout");
            Console.Write("Select an option: ");
        }

        public void DisplayOption1(Hotel hotel) 
        {
            Console.Clear();
            Console.WriteLine("List of all rooms");
            Console.WriteLine("                         ");
            foreach (var room in hotel.Rooms){Console.WriteLine($"Room {room.RoomNumber}: Type={room.RoomType}, Capacity={room.Capacity}, Price={room.Price}");}
           
            Console.WriteLine("                         ");
        }
            
        public void DisplayOption2(Hotel hotel) 
        {
            Console.Clear();
            Console.WriteLine("List of all Users");
            Console.WriteLine("                         ");
            foreach (var user in hotel.Users){Console.WriteLine($"UserName: {user.UserName}: ispersonal={user.IsPersonal}, Password={user.Password}, Guest={user.Guests}");}
           
            Console.WriteLine("                         ");
        }

        public void DisplayOption3() 
        {
            Console.Clear();
            Console.WriteLine("Hotel Management System - Main Menu");
            Console.WriteLine("                         ");
            Console.WriteLine("                         ");
            Console.WriteLine("3. Option 3 (Placeholder)");
            Console.WriteLine("4. Logout");
            Console.Write("Select an option: ");
        }
        public void DisplayOption4(Hotel hotel) 
        {
            double AvgScore = hotel.GetAvGScore();
            Console.Clear();
            Console.WriteLine("List of all Reviews");
            Console.WriteLine("                         ");
            foreach (var review in hotel.Reviews){Console.WriteLine($"Score: {review.ReviewNumber}: Review: {review.ReviewText}"); }
            Console.WriteLine("                         ");
            Console.WriteLine($"Avg reviewscore:{AvgScore}                        ");
            Console.WriteLine("                         ");

        }
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        
        public void Pause() //Prova Paus det ser bra ut
        {
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
