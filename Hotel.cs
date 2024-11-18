using System;

namespace HotelApp
{
public class Hotel
{
    public List<string> Reviews; 
    public List<Room> Rooms;
    public List<User> Users;

    public Hotel()
    {
        Reviews = new List<string>(); 
        Rooms = new List<Room>(); 
        Users = new List<User>();
        AddRooms();
        AddUsers();
        //AddReviews();
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

    }









            

        







    }
}
    