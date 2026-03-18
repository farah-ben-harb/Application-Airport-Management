using AM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public class FlightService : IFlightService
    {
        public IList<Flight> Flights { get; set; }
        public FlightService()
        {
            Flights = new List<Flight>();  
        }
        //public IList<DateTime> GetFlightDates(string destination)
        //{
        //    List<DateTime> result = new List<DateTime>();

        //    foreach (var flight in Flights)
        //    {
        //        if (flight.Destination == destination)
        //        {
        //            result.Add(flight.FlightDate);
        //        }
        //    }

        //    return result;
        //}
        //LINQ permet d’écrire des requêtes sur les listes(comme SQL mais en C#).

        //ou IEnumerable<DateTime>
        public IList<DateTime> GetFlightDates(string destination)
        {
            // LINQ : filtre les vols par destination et retourne les dates
            return Flights
                    .Where(f => f.Destination == destination)
                    .Select(f => f.FlightDate)
                    .ToList();
        }

        public void ShowFlightDetails(Plane plane)
        {
            //objet anonyme pour stocker les détails des vols
            var query = Flights
                        .Where(f => f.Plane == plane)
                        .Select(f => new { f.FlightDate, f.Destination });

            Console.WriteLine($"Détails des vols pour l'avion {plane.Planeid} :");
            foreach (var f in query)
            {
                Console.WriteLine($"Date: {f.FlightDate}, Destination: {f.Destination}");
            }
        }
        public int GetWeeklyFlightNumber(DateTime startDate)
        {
            DateTime endDate = startDate.AddDays(7); // fin de la semaine
            return Flights
                    .Count(f => f.FlightDate >= startDate && f.FlightDate <= endDate);
        }
    }
}
