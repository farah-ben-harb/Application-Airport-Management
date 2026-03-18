using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM.Core.Domain
{
    public class Passenger
    {

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Key] // Clé primaire
        [StringLength(7, MinimumLength = 7, ErrorMessage = "Le numéro de passeport doit contenir exactement 7 caractères")]
        public string PassportNumber { get; set; }
        [EmailAddress(ErrorMessage = "Adresse mail invalide")]
        public string EmailAddress { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Le prénom doit contenir au moins 3 caractères")]
        [MaxLength(25, ErrorMessage = "Le prénom ne doit pas dépasser 25 caractères")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string LastName { get; set; }
        [Phone(ErrorMessage = "Numéro de téléphone invalide")]
        public string TelNumber { get; set; }
       // public int PassengerId { get; set; }


        //properties of navigation
        public IList<Flight> Flights { get; set; }
        //constructors
        public Passenger() {
            Flights = new List<Flight>();
        }
        public Passenger(string firstName, string lastName, DateTime birthDate, string passportNumber, string emailAddress, string telNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            PassportNumber = passportNumber;
            EmailAddress = emailAddress;
            TelNumber = telNumber;
            Flights = new List<Flight>();
        }
        //toString override
        public override string ToString()
        {
            return $"Passenger: {FirstName} {LastName}, Birth Date: {BirthDate.ToShortDateString()}, Passport Number: {PassportNumber}, Email: {EmailAddress}, Tel: {TelNumber}";
        }
    

    //polymorphisme par heritage tp2
    //methode virtuelle 
    public virtual int GetPromotion()//renvoie pts de fidelite
    {
            return Flights.Count;

    }
    }
}
