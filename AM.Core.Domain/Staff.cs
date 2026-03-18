using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace AM.Core.Domain
{
    public class Staff:Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }

        [DataType(DataType.Currency)]
        public double Salary { get; set; }
        public Staff() { }
        public Staff(string firstName, string lastName, DateTime birthDate, string passportNumber, string emailAddress, string telNumber,
            DateTime employementDate, string function, int salary)
            : base(firstName, lastName, birthDate, passportNumber, emailAddress, telNumber)
        {
            EmployementDate = employementDate;
            Function = function;
            Salary = salary;
        }

        //toString override
        public override string ToString()
        {
            return base.ToString() + $", Employement Date: {EmployementDate.ToShortDateString()}, Function: {Function}, Salary: {Salary}";
        }

        //redefinition de la methode GetPromotion tp2
        public override int GetPromotion()//renvoie pts de fidelite
        {
            int years = DateTime.Now.Year - EmployementDate.Year;
            return Flights.Count + years;
        }
    }


}
