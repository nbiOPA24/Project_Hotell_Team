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

public enum Roomstatus
{
    Avalable,
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
    public string Room {get; set;}
    public string Customer {get; set;}
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
//Lägg in meny för customer 
//Lägg in meny för Staff