using System;

namespace HotelApp
{
    public class Room // Class room
    {
        public int RoomNumber {get; set; }
        public string RoomType {get; set; }
        public int Capacity {get; set; }
        public bool IsAvaliable {get; set; }
        public bool UnderMaintenance {get; set; }
        public int Price {get; set; }
        //Konstruktor till class Room
        public Room(int roomnumber, string roomtype, int capacity, bool isavaliable, bool undermaintenance, int price)
        {
            RoomNumber = roomnumber;
            RoomType = roomtype;
            Capacity = capacity;
            IsAvaliable = isavaliable; 
            UnderMaintenance = undermaintenance;
            Price = price;
        }
    }





}