using System;

namespace HotelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI();
            ui.Login();  

            bool running = true;
            while (running)
            {
                ui.DisplayMenu(); 
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ui.DisplayMessage("You selected Option 1.\n");
                        break;
                    case "2":
                        ui.DisplayMessage("You selected Option 2.\n");
                        break;
                    case "3":
                        ui.DisplayMessage("You selected Option 3.\n");
                        break;
                    case "4":
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
