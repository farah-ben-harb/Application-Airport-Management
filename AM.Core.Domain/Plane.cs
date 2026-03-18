using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AM.Core.Domain
{
    public class Plane
    {

        //properties
        [Range(1, int.MaxValue, ErrorMessage = "La capacité doit être un entier positif")]
        public int Capacity { get; set; }
        public int Planeid { get; set; }

        //properties of navigation
        public IList<Flight> Flights { get; set; }
        public PlaneType PlaneType { get; set; }
        public DateTime ManufactureDate { get; set; }

        //tp2 proprieté RO(pas de set ) 
        //renvoyer la date du premier vol
        public DateTime StartDate
        {
            get
            {
                if (Flights != null && Flights.Count > 0)
                {
                    //methode min de linq trouve la valeur minimale (exp lambda parcour de flights par f  )
                    return Flights.Min(f => f.FlightDate);//ancien date 
                }
                else
                {
                    return ManufactureDate;//si pas de vol retourne date de fabrication

                }
            }
        }

        // Ajout du constructeur par défaut pour corriger CS1729
        public Plane()
        {
            Flights = new List<Flight>();
        }

        // Constructeur paramétré existant
        public Plane(PlaneType planeType, int capacity, DateTime manufactureDate)
        {
            PlaneType = planeType;
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            Flights = new List<Flight>();
        }

        //toString override

        public override string ToString()
        {
              return $"Plane ID: {Planeid}, Capacity: {Capacity}, Manufacture Date: {ManufactureDate:yyyy-MM-dd}, Plane Type: {PlaneType}";
        }

    }
}
