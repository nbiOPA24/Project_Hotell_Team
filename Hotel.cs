using System;

namespace HotelApp
{
public class Hotel
{
    public List<Review> Reviews; 
    public List<Room> Rooms;
    public List<User> Users;

    public Hotel()
    {
        Reviews = new List<Review>(); 
        Rooms = new List<Room>(); 
        Users = new List<User>();
        AddRooms();
        AddUsers();
        AddReviews();
    }

    public void AddRooms()
    {
        for(int i = 0; i < 10; i++)
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
            Rooms.Add(new Room (RoomNumber, RoomType, Capacity, IsAvaliable, UnderMaintenance, Price));
        }
    }
        //om user == personal Password = 123
        // om user == guest password = 0 
    public void AddUsers()
    {
        Random random = new Random();
        string[] possibleNames = { "Alice", "Bob", "Charlie", "David", "Emma", "Fiona", "George", "Hannah", "Ian", "Jane" };

        // 
        for (int i = 0; i < 6; i++)
        {
            string name = " "; //Initialisera 
            if(i < 2)
            {
                name = possibleNames[random.Next(possibleNames.Length)];
                Users.Add(new User(name, true, "123", 0)); 
            }
                name = possibleNames[random.Next(possibleNames.Length)];
                Users.Add(new User(name, false, "0", random.Next(1, 5))); 
            

        }
    }

    public void AddReviews()
    {

        Reviews.Add(new Review(5, "Riktigt bra hotel!"));
        Reviews.Add(new Review(4, "Barnfritt och mysigt hotel!"));
        Reviews.Add(new Review(3, "Bra sängar och service!"));
        Reviews.Add(new Review(2, "Bra frukost!"));
    }
    
public void AddNewReview()
    {

        bool validInput = false;
        int reviewScore = 0;
        Console.WriteLine("On a scale from 1-5 how would you rate your stay?");

        string input = Console.ReadLine();

            if (int.TryParse(input, out reviewScore))
            {

                if (reviewScore <2)
                {
                    Console.WriteLine("Were sorry 😦 and hope you would give us another chance!");
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

        public double GetAvGScore()
        {
            double totalScore = 0;
            foreach (var review in Reviews)
            {
                totalScore += review.ReviewNumber;
            }
            return totalScore / Reviews.Count;        
        }
        
        public void Booking()
        {   
            foreach (var room in Rooms){Console.WriteLine($"Room {room.RoomNumber}: Type={room.RoomType}, Capacity={room.Capacity}, Price={room.Price}");}

            Console.WriteLine("Witch room would you like to book?");
        }

        public User Login()
        {
            Console.WriteLine("Please enter your username:");
            string username = Console.ReadLine();

            
            User user = Users.Find(u => u.UserName == username);

            if (user != null)
            {
            
                Console.WriteLine("Please enter your password (0 for guests):");
                string password = Console.ReadLine();

                
                if (user.Password == password)
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

                    
                    string defaultPassword = "0"; 
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
            return null;
        }
}   }
