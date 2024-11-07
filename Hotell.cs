//To do list project hotellet.
//Grovt är detta vad jag tänker ska ingå i programmet, det kommer säkerligen revideras men för att ha en utgångspunkt. 

//To do list för Hotellhanteringssystemet

//Generella uppgifter (gäller hela systemet):
//Rum rumstyp, kapacitet, pris, status ledig, bokad, etc.
//Bokningar kund, rum, datum, status
//Kunder (namn, kontakt info)
//Personal (namn, roll)
//Reviews (rum, kund, betyg, kommentar)

//Skapa användarroller:
//Definiera kund och personalroller med olika rättigheter (ex. kunden får bara boka, personal får hantera rum och bokningar).Tänker få in lite private och protected )
//Bygga autentisering och login-system:
//Kunder och personal ska kunna logga in med olika användarroller.
//Designa en lättnavigerad användargränssnitt där kunder och personal enkelt kan använda systemet.

// Enum för available, booked och undermaintenance
public enum Roomstatus
{
    Available,
    Booked,
    UnderMaintenance,
}

public class Room
{
    public int Roomid {get; set;}
    public string Roomtype {get; set;}
    public int Capacity {get; set;}
    public Roomstatus Status {get; set;}
    //Konstruktor till klassen Room
    public Room(int roomid, string roomtype, int capacity, Roomstatus status)
    {
        Roomid = roomid;
        Roomtype = roomtype;
        Capacity = capacity;
        Status = status;
    }
    //Metod kopplat till Available i enum och för att se om rummet är ledigt.
    public bool IsAvailable()
    {
        return Status == Roomstatus.Available;
    }

    //Metod för att boka rummet
    public void Book()
    {
        if(IsAvailable())
        {
            Status = Roomstatus.Booked;
            Console.WriteLine("Rummet har bokats!");
        }
        else
        {
            Console.WriteLine("Rummet är tyvärr inte tillgängligt");
        }
    }
    //Metod för att sätta rum under underhåll
    public void SetUnderMaintenance()
    {
        if(Status != Roomstatus.UnderMaintenance)
        {
            Status = Roomstatus.UnderMaintenance;
            Console.WriteLine($"Rummet {Roomtype} med ID {Roomid} är nu satt till underhåll");
        }
        else
        {
            Console.WriteLine($"Rummet {Roomtype} med ID {Roomid} är redan under underhåll");
        }
    }
}

public class Booking
{
    public int Bookingid {get; set;}
    public Customer Customer {get; set;}
    public Room Room {get; set;}
    public DateTime Startdate {get; set;}
    public DateTime Enddate {get; set;}
    public string Status {get; set;}
    //Konstruktor till klassen Booking
    public Booking(int bookingid, Customer customer, Room room, DateTime startdate, DateTime enddate, string status)
    {
        Bookingid = bookingid;
        Customer = customer;
        Room = room;
        Startdate = startdate;
        Enddate = enddate;
        Status = status;
    }
    //Metod för att bekräfta en bokning
    public void ConfirmBooking()
    {
        Status = "Confirmed";
        Console.WriteLine($"Bokning {Bookingid} är bekräftad för kund {Customer.Name}");
    }

    //Metod för att kunna avboka en bokning
    public void CancelBooking()
    {
        Status = "Cancelled";
        Console.WriteLine($"Bokning {Bookingid} har avbokats av kund {Customer.Name}");
    }
}

public class Customer
{
    public int Customerid {get; set;}
    public string Name {get; set;}
    public string Contactinfo {get; set;}
    public string Role {get; set;}
    //Konstruktor till klassen Customer
    public Customer(int customerid, string name, string contactinfo, string role)
    {
        Customerid = customerid;
        Name = name;
        Contactinfo = contactinfo;
        Role = role;
    }
}

public class Staff
{
    public int Staffid {get; set;}
    public string Name {get; set;}
    public string Role {get; set;}
    //Konstruktor till klassen Staff
    public Staff(int staffid, string name, string role)
    {
        Staffid = staffid;
        Name = name;
        Role = role;
    }
}

public class Review
{
    public int Reviewid {get; set;}
    public Room Room {get; set;} // Ref direkt till ett room-objekt
    public Customer Customer {get; set;} // Ref direkt till ett customer-objekt
    public int Rating {get; set;}
    public string Comment {get; set;}
    //Konstruktor till klassen Review
    public Review(int reviewid, string room, string customer, int rating, string comment)
    {
        Reviewid = reviewid;
        Room = room;
        Customer = customer;
        Rating = rating;
        Comment = comment;
    }
    //Metod för att kunna visa reviews
    public void ShowReview()
    {
        Console.WriteLine("Recensionsdetaljer:");
        Console.WriteLine($"Recension ID: {Reviewid}");
        Console.WriteLine($"Rum: {Room.Roomtype} ID: {Room.Roomid}");
        Console.WriteLine($"Kund: {Customer.Name}");
        Console.WriteLine($"Betyg: {Rating}/5");
        Console.WriteLine($"Kommentar: {Comment}");
    }
}

public class User
{
    public string Username {get; set;}
    public string Password {get; set;}
    public string Role {get; set;}

    //Konstruktor till klassen user
    public User(string username, string password, string role)
    {
        Username = username;
        Password = password;
        Role = role;
    }
   
    public bool Authenticate(string password)
    {
        return Password == password;
    }
}

//Ska hantera funktionerna i hotellhanteringssystemet
public class HotelSystem 
{
    private List<Room> rooms = new List<Room>();
    private List<Booking> bookings = new List<Booking>();
    private List<Review> reviews = new List<Review>();

    //Metod för att kunna lägga till ett rum:
    public void AddRoom(Room room)
    {
        rooms.Add(room);
        Console.WriteLine($"Rum {room.Roomtype} med ID {room.Roomid} har lagts till");
    }

    //Autentisering och meny för val som senare ska innehålla en menu för kunder och personal 
    //Dessa ska kallas ShowCustomerMenu och ShowStaffMenu:
    public void AuthenticateAndShowMenu(User user)
    {
        if(user.Role == "Customer")
        {
            Console.WriteLine($"Välkommen {user.Username} Du är inloggad som kund ");
            ShowCustomerMenu();
        }
        else if(user.Role == "Staff")
        {
            Console.WriteLine($"Välkommen {user.username} du är inloggad som personal");
            ShowCustomerMenu();
        }
        else
        {
            Console.WriteLine("ogiltigt roll");
        }
    }










}
//Lägg in meny för customer 
//Lägg in meny för Staff

class Program 
{
    static void Main()
    {
        Console.WriteLine("Välkommen till Hotellhanteringssystemet");
        Console.WriteLine("1. Logga in som kund");
        Console.WriteLine("2. Logga in som personal");//Lägg till lösenord
        Console.WriteLine("3. Avsluta");
    }
}
// if eller switch case
