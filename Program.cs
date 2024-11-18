using System;
using System.Runtime.CompilerServices;

namespace HotelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();
            Hotel hotel = new Hotel();



            Console.WriteLine("Welcome to the Hotel Management System");
            Console.Write("Are you an employee? (y/n): ");
            string IsEmployee = Console.ReadLine().ToLower();  // Read input and convert to lowercase

            // Compare with "y" since IsEmployee is a string
            if (IsEmployee == "y")
            {
                Console.WriteLine("Employee access granted!");
            }
            else
            {
                Console.WriteLine("Welcome guest!");
            }

            bool running = true;
            while (running)
            {
                if(IsEmployee != "y"){
                    ui.DisplayMenu();
                }
                else{
                    ui.DisplayMenuEmployee();
                }
                

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ui.DisplayMessage("You selected Option 1.\n");
                        ui.DisplayRooms(hotel);
                        break;
                    case "2":
                        if (IsEmployee == "y")
                        {
                            ui.DisplayMessage("Review!.\n");
                            ui.DisplayReviews(hotel);
                            break;
                        }
                        else
                        {
                            ui.DisplayReviews(hotel);
                            ui.DisplayMessage("Review!.\n");
                            hotel.AddNewReview();
                            break;
                        }
                    case "3":
                        if (IsEmployee != "y"){
                            break;
                        }
                            ui.DisplayMessage("You selected Option 2.\n");
                            ui.DisplayUsers(hotel);
                            break;
                    case "4":
                    // Under construction
                        break;
                    case "5":
                        ui.DisplayMessage("Logging out...\n");
                        running = false;
                        break;
                    default:
                        ui.DisplayMessage("Invalid choice. Please try again.\n");
                        break;
                }

                if (running)
                {
                    ui.Pause();
                }
            }
        }
    }
}