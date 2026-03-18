using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AM.Core.Domain
{
    public class Flight
    {
        public string? Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        // Clé étrangère
        [Key]
        public int Flightid { get; set; }  // correct
        public DateTime EffectiveArrival { get; set; }
        public int EstimateDuration { get; set; }

        //properties of navigation
        public Plane Plane { get; set; }

        public IList<Passenger> Passenger { get; set; }

        //tp4
        public string Comment { get; set; }
        public int PlaneId { get; set; }

        //constructors
        public Flight() { }
        public Flight(string destination, string departure, DateTime flightDate, DateTime effectiveArrival, int estimateDuration)
        {
            Destination = destination;
            Departure = departure;
            FlightDate = flightDate;
            EffectiveArrival = effectiveArrival;
            EstimateDuration = estimateDuration;
            Passenger = new List<Passenger>();
        }
        //toString override
        public override string ToString()
        {
            return $"Flight ID: {Flightid}, From: {Departure} To: {Destination}, Flight Date: {FlightDate}, Effective Arrival: {EffectiveArrival}, Estimated Duration: {EstimateDuration} minutes";
        }

        //polymorphisme par signature=surcharge tp2
        //retard=duree reelle(eefectiveArrival-FlightDate) >duree estimee(EstimateDuration)
        public int CheckLostTime(Flight f)
        {
            int realDuration = (int)(f.EffectiveArrival - f.FlightDate).TotalMinutes;
            int retard = realDuration - f.EstimateDuration;
            return retard;
        }
        public int CheckLostTime()
        {
            int realDuration = (int)(EffectiveArrival - FlightDate).TotalMinutes;
            return realDuration - EstimateDuration;
        }

        // 3. Peut-on remplacer les deux par une seule ?
        // Non, car les signatures sont différentes.
        //C# les considère comme deux méthodes différentes

    }
}
