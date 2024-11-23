using System;

namespace HotelApp
{
    public class Room // Class room
    {
        public int RoomNumber {get; set; }
        public string RoomType {get; set; }
        public int Capacity {get; set; }
        public bool IsAvailable {get; set; }
        public bool UnderMaintenance {get; set; }
        public int Price {get; set; }

        public string GuestName {get; set; }



        //Konstruktor till class Room
        public Room(int roomnumber, string roomtype, int capacity, bool isavailable, bool undermaintenance, int price, string guestname)
        {
            RoomNumber = roomnumber;
            RoomType = roomtype;
            Capacity = capacity;
            IsAvailable = isavailable; 
            UnderMaintenance = undermaintenance;
            Price = price;
            GuestName = guestname;
            
        }
        public void BookRoomForGuest(string guestName)
        {
        GuestName = guestName;
        IsAvailable = false;
        }
        public void VacateRoom()
        {
        GuestName = null;
        IsAvailable = true;
        }
    
    }
}

    

    
    
    
    

        

        


