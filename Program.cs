using System;

namespace HotelApp
{
    class Program
    {
        static void Main(string[] args) 
        { 
            UI ui = new UI();
            Hotel hotel = new Hotel();

            Console.WriteLine("Welcome to the Hotel Management System");
            Console.Write("Are you an employee? (y/n:");
            string IsEmployee = Console.ReadLine().ToLower(); // Read input and convert to lowercase

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
                ui.DisplayMenu(); 
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": 
                   
                        ui.DisplayMessage("You selected Option 1.\n"); 
                        ui.DisplayOption1(hotel);
                        break;
                    case "2":
                        if (IsEmployee == "y")
                        {
                            ui.DisplayMessage("You selected Option 2.\n");
                            ui.DisplayOption2(hotel);
                            break;
                        }
                        else
                        {
                            break;
                        }
                            
                    case "3":
                        ui.DisplayMessage("You selected Option 3.\n");
                        ui.DisplayOption3();
                        break;
                    case "4":
                        if (IsEmployee != "y")
                        {
                            ui.DisplayMessage("Review.\n");
                            hotel.AddNewReview();
                            break;
                        }
                        else 
                        {
                            ui.DisplayOption4(hotel);
                            break;
                        }

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

