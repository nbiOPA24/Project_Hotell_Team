using System;

namespace HotelApp
{
    
    public class Review // Class Review
    {
       public int ReviewNumber {get; set; }
       public string ReviewText {get; set; }
    //Konstruktor till Class Review
        public Review(int reviewnumber, string reviewtext) 
        {
            ReviewNumber = reviewnumber;
            ReviewText = reviewtext;
        }
    }
}
    
    
