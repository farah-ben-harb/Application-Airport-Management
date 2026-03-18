using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Traveller : Passenger
    {
        public string Healthinformation { get; set; }
        public string Nationality { get; set; }

        public Traveller() { }
        public Traveller(string firstName, string lastName, DateTime birthDate, string passportNumber, string emailAddress, string telNumber,
            string healthinformation, string  Nationality): base(firstName, lastName, birthDate, passportNumber, emailAddress, telNumber)
        {
            
            Healthinformation = healthinformation;
            Nationality = Nationality;


        }
        //toString override
        public override string ToString()
        {
 
            return base.ToString() + $", Health Information: {Healthinformation} , Nationality : {Nationality}";
        }
    }
}
