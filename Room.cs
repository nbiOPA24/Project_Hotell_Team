using System;

namespace HotelApp
{
    public class Room // Class room
    {
        public int RoomNumber {get; set; } // Room number
        public string RoomType {get; set; } // Type of room
        public int Capacity {get; set; } // Number of people the room can hold
        public bool IsAvailable {get; set; } // Whether the room is available
        public bool UnderMaintenance {get; set; } // Whether the room is under maintenance
        public int Price {get; set; } // Price per night

        public string GuestName {get; set; } // Name of the guest in the room



       // Constructor for the Room class
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

    

    
    
    
    

        

        


