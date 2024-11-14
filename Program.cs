using System;

namespace HotelApp
{
    class Program
    {
        static void Main(string[] args) 
        { 
            UI ui = new UI();
            Hotel hotel = new Hotel();
            ui.Login();  

            bool running = true;
            while (running)
            {
                ui.DisplayMenu(); 
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": 
                        foreach (var room in hotel.Rooms)
                        {
                            Console.WriteLine($"Room {room.RoomNumber}: Type={room.RoomType}, Capacity={room.Capacity}, Price={room.Price}");
                        }
                        //ui.DisplayMessage("You selected Option 1.\n"); 
                        //ui.DisplayOption1();
                        break;
                    case "2":
                        ui.DisplayMessage("You selected Option 2.\n");
                        ui.DisplayOption2();
                        break;
                    case "3":
                        ui.DisplayMessage("You selected Option 3.\n");
                        ui.DisplayOption3();
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

