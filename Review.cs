using System;

namespace HotelApp
{
    
    public class Review // Class Review
    {
       public int ReviewNumber {get; set; } // Rating score
       public string ReviewText {get; set; } // Text of the review
        // Constructor for the Review class
        public Review(int reviewnumber, string reviewtext) 
        {
            ReviewNumber = reviewnumber;
            ReviewText = reviewtext;
        }
    }
}
    
    

