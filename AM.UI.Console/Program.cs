using AM.Core.Domain;
using AM.Core.Extensions;
using AM.Core.Services;
using AM.Data;

// 7. Instancier un avion avec constructeur par défaut
//L’objet est créé vide, puis on remplit les propriétés une par une
Plane p1 = new Plane();
p1.Planeid = 1;
p1.Capacity = 200;
p1.PlaneType = PlaneType.Airbus;
p1.ManufactureDate = new DateTime(2015, 01, 01);

Console.WriteLine("Plane 1 : " + p1);

// 8. Instancier avec constructeur paramétré
//Le constructeur définit directement les valeurs obligatoires
Plane p2 = new Plane(PlaneType.Boeing, 300, DateTime.Now);
p1.Planeid = 2;

Console.WriteLine("Plane 2 : " + p2);

// 9. Instancier avec object initializer
Plane p3 = new Plane
{

    PlaneType = PlaneType.Airbus,
    Capacity = 180,
    ManufactureDate = new DateTime(2020, 05, 15)
};
p3.Planeid = 3;


Console.WriteLine("Plane 3 : " + p3);

//tp2
Passenger p = new Passenger();
p.Flights.Add(new Flight());
p.Flights.Add(new Flight());

Passenger s = new Staff
{
    EmployementDate = new DateTime(2018, 06, 01),
  
}; s.Flights.Add(new Flight());
s.Flights.Add(new Flight());

Passenger t= new Traveller();
t.Flights.Add(new Flight());
t.Flights.Add(new Flight());
t.Flights.Add(new Flight());

Console.WriteLine("Passenger Promotion = " + p.GetPromotion());
Console.WriteLine("Staff Promotion = " + s.GetPromotion());
Console.WriteLine("Traveller Promotion = " + t.GetPromotion());

//tester methode extension
Flight f1 = new Flight(
    "Tunis",
    "Paris",
    new DateTime(2025, 11, 25, 10, 0, 0), // départ
    new DateTime(2025, 11, 25, 12, 30, 0), // arrivée effective
    120 // durée estimée 
);
p.Flights.Add(f1);
s.Flights.Add(f1);
t.Flights.Add(f1);
Console.WriteLine("Retard du vol f1 : " + f1.GetDelay() + " minutes");

//tp3
FlightService service = new FlightService();

Plane pp = new Plane(PlaneType.Airbus, 200, DateTime.Now);
Flight ff = new Flight("Paris", "Tunis", DateTime.Now, DateTime.Now.AddHours(2), 120) { Plane = p1 };
Flight fff = new Flight("Paris", "Tunis", DateTime.Now.AddDays(1), DateTime.Now.AddDays(1).AddHours(2), 120) { Plane = p1 };

service.Flights.Add(ff);
service.Flights.Add(fff);

// Test GetFlightDates
var dates = service.GetFlightDates("Paris");
Console.WriteLine("Dates des vols vers Paris :");
foreach (var d in dates)
    Console.WriteLine(d);

// Test ShowFlightDetails
service.ShowFlightDetails(p1);

// Test GetWeeklyFlightNumber
Console.WriteLine("Nombre de vols cette semaine : " + service.GetWeeklyFlightNumber(DateTime.Now));


//tp4
using (var ctx = new AMContext())
{
    ctx.Flights.Add(new Flight
    {
        FlightDate = DateTime.Now,
        Destination = "Paris",
        Comment = "Vol calme"
    });

    ctx.SaveChanges();
}

Console.ReadKey();
