using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class Manager : User
    {
        //instance variables
        protected String position;

        //constructor 
        public Manager(int id, string name, String password, string email, String gender, string phoneNumber, string address, double hourlyWage, double hoursWorked, DateTime birthDate, int holidayDays, int sickDays, String position) :
            base(id, name, password, email, gender, phoneNumber, address, hourlyWage, hoursWorked, birthDate,  holidayDays, sickDays)
        {
            this.position = position;
        }

        //properties
        public String Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        //methods
        public override String ToString()
        {
            return $"Manager: ID - {id}, Name - {name}, Email - {email}, Phonenumber - {phoneNumber}";
        }
    }
}
