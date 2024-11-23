using System;

namespace HotelApp
{
    public class UI
    {
        public bool IsEmployee { get; private set; } 

        
        public void Login() // login process
        {
            Console.WriteLine("Welcome to the Hotel Management System");
            Console.Write("Are you an employee? (y/n): ");
            string input = Console.ReadLine();

            IsEmployee = input.ToLower() == "y";
            Console.WriteLine(IsEmployee ? "Login successful! Welcome, Employee.\n" : "Login successful! Welcome, Guest.\n");
        }

        

        public void DisplayMenu() // Display the main menu for guests
        {
            Console.Clear();
            Console.WriteLine("Hotel Management System - Main Menu");
            Console.WriteLine("1. Book room");
            Console.WriteLine("2. Review");
            Console.WriteLine("5. Logout");
            Console.Write("Select an option: ");
        }

        public void DisplayMenuEmployee() // Display the main menu for staff
        {
            Console.Clear();
            Console.WriteLine("Hotel Management System - Main Menu");
            Console.WriteLine("1. Rooms ");
            Console.WriteLine("2. Reviews ");
            Console.WriteLine("3. Users");
            Console.WriteLine("4. Book/Maintence");
            Console.WriteLine("5. Logout");
            Console.Write("Select an option: ");
        }
        public void DisplayRooms(Hotel hotel) // Display all rooms and their details
        {
            Console.Clear();
            Console.WriteLine("List of all rooms");
            Console.WriteLine("                         ");
            foreach (var room in hotel.Rooms){Console.WriteLine($"Room {room.RoomNumber}: Type={room.RoomType}, Capacity={room.Capacity}, Price={room.Price}, Guest={room.GuestName}");}
           
            Console.WriteLine("                         ");
        }
            
        public void DisplayUsers(Hotel hotel) // Display users
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
        public void DisplayReviews(Hotel hotel) // Display reviews
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
        public void DisplayMessage(string message) // Display a message to the user
        {
            Console.WriteLine(message);
        }

        
        public void Pause() // Pause the program until the user presses Enter
        {
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
