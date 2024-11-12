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
            Console.WriteLine("1. Option 1 (Placeholder)");
            Console.WriteLine("2. Option 2 (Placeholder)");
            Console.WriteLine("3. Option 3 (Placeholder)");
            Console.WriteLine("4. Logout");
            Console.Write("Select an option: ");
        }

        public void DisplayOption1() 
        {
            Console.Clear();
            Console.WriteLine("Hotel Management System - Main Menu");
            Console.WriteLine("1. Option 1 (Placeholder)");
            Console.WriteLine("                         ");
            Console.WriteLine("                         ");
            Console.WriteLine("4. Logout");
            Console.Write("Select an option: ");
        }

        public void DisplayOption2() 
        {
            Console.Clear();
            Console.WriteLine("Hotel Management System - Main Menu");
            Console.WriteLine("                         ");
            Console.WriteLine("2. Option 2 (Placeholder)");
            Console.WriteLine("                         ");
            Console.WriteLine("4. Logout");
            Console.Write("Select an option: ");
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
