using System;

namespace HotelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI(); // Creates a new UI object to manage user interface
            Hotel hotel = new Hotel(); // Creates a Hotel object to manage rooms, users, and reviews

            // Login process
            User LoggedIn = hotel.Login(); // Handles login for guest or staff

            // If the user successfully logs in
            if (LoggedIn != null)
            {
                bool running = true;

                while (running)
                {
                    // Display the menu based on whether the user is an employee or guest
                    if (LoggedIn.IsPersonal)
                    {
                        ui.DisplayMenuEmployee();  // Employee-specific menu
                    }
                    else
                    {
                        ui.DisplayMenu();  // Guest-specific menu
                    }

                    string choice = Console.ReadLine();

                    // Handle user choice
                    switch (choice)
                    {
                        case "1":
                            if(LoggedIn.IsPersonal)
                            {
                                hotel.BookRoomPersonnel();
                            }
                            else
                            {
                                hotel.BookRoomGuest(LoggedIn);
                            }
                            ui.DisplayMessage("You selected Option 1.\n");
                            ui.DisplayRooms(hotel);  // Display rooms for both employees and guests
                            break;

                        case "2":
                            if (LoggedIn.IsPersonal)  // If employee
                            {
                                ui.DisplayMessage("Employee can manage reviews.\n");
                                ui.DisplayReviews(hotel);  // Display reviews for employee
                            }
                            else  // If guest
                            {
                                ui.DisplayReviews(hotel);  // Display reviews for guest
                                ui.DisplayMessage("Reviewing your stay...\n");
                                hotel.AddNewReview();  // Allow guest to add a review
                            }
                            break;

                        case "3":
                            if (!LoggedIn.IsPersonal)  // Skip for guests
                            {
                                break;
                            }
                                ui.DisplayMessage("You selected Option 2: View Users.\n");
                                ui.DisplayUsers(hotel);  // Display users for employees
                                break;

                        case "4":
                            if (!LoggedIn.IsPersonal)  // Only for staff
                            {
                                Console.WriteLine("Access denied. This option is available only for staff.");
                            break;
                            }
                                Console.WriteLine("Staff-specific function (Add or Manage Rooms)");
                                hotel.AddRoomsAdmin();  // Staff can add new rooms
                                break;

                        case "5":
                            ui.DisplayMessage("Logging out...\n");
                            running = false;  // Exit the loop, user logs out
                            break;

                        default:
                            ui.DisplayMessage("Invalid choice. Please try again.\n");
                            break;
                    }

                    // Pause before showing the menu again
                    if (running)
                    {
                        ui.Pause();
                    }
                }
            }
        }
    }
}