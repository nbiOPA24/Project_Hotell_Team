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
        //AddUsers();
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


    //Kod för att bygga en autopopulator för rooms.
    //Kod för att bygga en autopopulator för users
    //Kod för att bygga en autopopulator för reviews.
    

















  
    












}









}