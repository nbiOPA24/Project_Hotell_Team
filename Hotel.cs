using System;

namespace HotelApp
{
public class Hotel
{
    public List<Review> Reviews; // Stores all reviews left by guests
    public List<Room> Rooms; // Stores all room data
    public List<User> Users; // Stores all user data (both guests and staff)

    public Hotel()
    {
        Reviews = new List<Review>(); // Initialize review list
        Rooms = new List<Room>(); // Initialize room list
        Users = new List<User>(); // Initialize user list
        AddRooms(); // Adds rooms
        AddUsers(); // Adds users
        AddReviews(); // Adds reviews
    }

    public void AddRooms() // Add default rooms to the system
    {
            Rooms.Add(new Room(1020, "standard", 4, false, false, 500, "Kalle" ));
        
        for(int i = 0; i < 10; i++) // Loop to dynamically create rooms
        {
            int RoomNumber = 1000 + i;

            string RoomType = "Standard";
                if(i > 7)
                    {RoomType = "Deluxe";}
            
            int Capacity = 4; 
                if(RoomType == "Deluxe")
                    {Capacity = 6;}
            
            bool IsAvaliable = true;
            bool UnderMaintenance = false;
            
            int Price = 500;
                if(RoomType == "Deluxe")
                    {Price = 1000;}

            string guestname = null; // Initially no guest       
            Rooms.Add(new Room (RoomNumber, RoomType, Capacity, IsAvaliable, UnderMaintenance, Price, guestname));
        }
        
    }

   public void AddRoomsAdmin() // Staff adds a new room
    {
        int RoomNumber = 1000 + Rooms.Count()+1; // Automatically generate the next room number
        string GuestName = null; // Default no guest assigned
        string RoomType = "Standard";
        bool IsAvailable = true;
        bool UnderMaintenance = false;
        int Capacity = 4;
        int Price = 500;

        Console.WriteLine("Enter the name of the guest(Leave empty if no guest)");
        string input = Console.ReadLine();
        if (input != null)
        {
            GuestName = input;
            Console.WriteLine("How many quests?(1-6)");
            int Guests = int.Parse(Console.ReadLine());
                if(Guests > 4)
                {
                    RoomType = "Deluxe"; // Update to Deluxe if more than 4 guests
                    Capacity = 6;
                    IsAvailable = false;  // Room is booked
                    Price = 1000;
                }

        }

        // Capacity to 6 
        // RoomType to Deluxe
        // If you have no guests

        Rooms.Add(new Room (RoomNumber, RoomType, Capacity, IsAvailable, UnderMaintenance, Price, GuestName));
    }
    
    public void RemoveRoom() // Removes a room by its room number
    {
        Console.WriteLine("Which Room would you like to remove?");
        int roomNumber = int.Parse(Console.ReadLine());

        // Remove room by RoomNumber
        int removedCount = Rooms.RemoveAll(room => room.RoomNumber == roomNumber);

        if (removedCount > 0)
        {
            Console.WriteLine($"Room {roomNumber} has been removed.");
        }
        else
        {
            Console.WriteLine($"No room found with RoomNumber {roomNumber}.");
        }
    }
      
        
        
        //if user == personal Password = 123
        // if user == guest password = 0 
    public void AddUsers() // Adds default users to the system
    {
        Random random = new Random();
        string[] possibleNames = { "Alice", "Bob", "Charlie", "David", "Emma", "Fiona", "George", "Hannah", "Ian", "Jane" };
        
        Users.Add(new User("Admin", true, "123", 0)); // For logging write Admin Password 123
        

        
        for (int i = 0; i < 6; i++) // Adds 2 staff users and 4 guest users 
        {
            string name = " "; //Initialisera 
            if(i < 2)
            {
                name = possibleNames[random.Next(possibleNames.Length)];
                Users.Add(new User(name, true, "123", 0));  // Staff users
            }
                name = possibleNames[random.Next(possibleNames.Length)];
                Users.Add(new User(name, false, "0", random.Next(1, 5))); // Guest users
            

        }
    }

    public void AddReviews() // Add default reviews to the system
    {

        Reviews.Add(new Review(5, "Really nice hotel!"));
        Reviews.Add(new Review(4, "Child free and nice hotel!"));
        Reviews.Add(new Review(3, "Good serice and beds!"));
        Reviews.Add(new Review(2, "Great Breakfest!"));
    }
    
    public void AddNewReview() // Allows guests to add a new review
    {

        bool validInput = false;
        int reviewScore = 0;
        Console.WriteLine("On a scale from 1-5 how would you rate your stay?");

        string input = Console.ReadLine();

            if (int.TryParse(input, out reviewScore))
            {

                if (reviewScore <2)
                {
                    Console.WriteLine("Were sorry and hope you would give us another chance!");
                    validInput = true; 
                }
                if (reviewScore >= 2 && reviewScore <= 5)
                {
                    validInput = true;  
                }
                else
                {
                    Console.WriteLine("Please enter a rating between 1 and 5.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            }


            Console.WriteLine("How would you describe your stay?");
            string reviewString = Console.ReadLine();

            Reviews.Add(new Review(reviewScore, reviewString));

        }

        public double GetAvGScore() // Calculates the average review score
        {
            double totalScore = 0;
            foreach (var review in Reviews)
            {
                totalScore += review.ReviewNumber;
            }
            return totalScore / Reviews.Count; // Return the average        
        }
        
        public void Booking() // Displays all available rooms for booking
        {   
            foreach (var room in Rooms){Console.WriteLine($"Room {room.RoomNumber}: Type={room.RoomType}, Capacity={room.Capacity}, Price={room.Price}");}

            Console.WriteLine("Witch room would you like to book?");
        }

        public User Login()  // Handles the login process for both staff and guest
        {
            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();

            
            User user = Users.Find(u => u.UserName == username); // Find the user by username

            if (user != null)
            {
            
                Console.WriteLine("Please enter your password (0 for guests):");
                string password = Console.ReadLine();

                
                if (user.Password == password) // Check if the password matches
                {
                    Console.WriteLine($"{username}, you are logged in as {(user.IsPersonal ? "Employee" : "Guest")}.");
                    return user;
                }
                else
                {
                    Console.WriteLine("Incorrect password.");
                }
            }
            else
            {
                
                Console.Write("Username not found. Would you like to create a new guest profile? (y/n): ");
                string response = Console.ReadLine().ToLower();

                if (response == "y")
                {
                    
                    Console.Write("Please enter your name: ");
                    string name = Console.ReadLine();

                    Console.Write("How many people will be staying in the same room? ");
                    int peopleCount;
                    while (!int.TryParse(Console.ReadLine(), out peopleCount) || peopleCount < 1)
                    {
                        Console.Write("Please enter a valid number of people (1 or more): ");
                    }

                    
                    string defaultPassword = "0"; // Default password for guests
                    User newGuest = new User(name, false, defaultPassword, peopleCount); 
                    Users.Add(newGuest); 

                    Console.WriteLine($"New guest profile created for {name} with {peopleCount} people.");
                    return newGuest; 
                }
                else
                {
                    Console.WriteLine("Returning to the main menu.");
                }
            }
            return null; // Login failed
        }
        public void BookRoomGuest(User user) // Guest books a room
            {
            
            Console.WriteLine("Available Rooms:");
            List<Room> availableRooms = new List<Room>();

            if (user.Guests <= 4)
            {
                availableRooms.AddRange(Rooms.Where(room => room.Capacity >= user.Guests && room.IsAvailable && !room.UnderMaintenance));
            }
            else
            {
                availableRooms.AddRange(Rooms.Where(room => room.Capacity >= user.Guests && room.IsAvailable && !room.UnderMaintenance && room.RoomType == 	"Deluxe"));
            }

            if (availableRooms.Count == 0 )
            {
                Console.WriteLine("No available rooms that fit your critera");
                return;
            }
            
            foreach (var room in availableRooms)
            {
                Console.WriteLine($"Room {room.RoomNumber}: Type={room.RoomType}, Capacity={room.Capacity}, Price={room.Price}");
            }

            if (availableRooms.Count == 0)
            {
                Console.WriteLine("No available rooms that fit your criteria.");
                return;
            }

            
            Console.WriteLine("Enter the room number to book:");
            if (!int.TryParse(Console.ReadLine(), out int selectedRoomNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid room number.");
                return;
            }
            
            Room selectedRoom = availableRooms.FirstOrDefault(room => room.RoomNumber == selectedRoomNumber);

            if (selectedRoom != null)
            {
                
                Console.WriteLine($"You selected Room {selectedRoom.RoomNumber}. Price: {selectedRoom.Price}.");
                Console.WriteLine("Do you accept the price? (y/n): ");
                string confirmation = Console.ReadLine().ToLower();

                if (confirmation == "y")
                {
                    selectedRoom.BookRoomForGuest(user.UserName);  // Mark room as booked
                    Console.WriteLine($"Room {selectedRoom.RoomNumber} has been booked successfully for {user.UserName}.");
                }
                else
                {
                    Console.WriteLine("Booking cancelled.");
                }
            }
            else
            {
                Console.WriteLine("Invalid room selection.");
            }
        }
        public void BookRoomPersonnel() // Handles staff room booking and check-in
        {
            Console.WriteLine("Enter the room number to book or vacate:");
            int roomNumber = int.Parse(Console.ReadLine());
            Room room = Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

        if (room != null)
        {
            if (room.IsAvailable)
            {
                
                Console.WriteLine("Enter the guest's name:");
                string guestName = Console.ReadLine();
                room.BookRoomForGuest(guestName); // Book the room for the guest
                Console.WriteLine($"Room {room.RoomNumber} has been booked for {guestName}.");
            }
            else
            {
                
                Console.WriteLine("The room is currently occupied. Do you want to vacate the room? (y/n):");
                string vacateChoice = Console.ReadLine().ToLower();

                if (vacateChoice == "y")
                {
                    room.VacateRoom(); 
                    Console.WriteLine($"Room {room.RoomNumber} has been vacated and is now available.");
                }
                else
                {
                    Console.WriteLine("Room not vacated.");
                }
        }
    }
    else
    {
        Console.WriteLine("Invalid room selection.");
    }
    }
    
    } 

}
