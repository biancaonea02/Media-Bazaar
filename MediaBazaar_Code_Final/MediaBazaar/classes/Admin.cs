using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    class Admin : Manager
    {
        //constructor
        public Admin(int id, string name,string password, string email, string gender, string phoneNumber, string address, double hourlyWage, double hoursWorked, DateTime birthDate, int holidayDays, int sickDays, string position)
            : base(id, name, password, email, gender, phoneNumber, address, hourlyWage, hoursWorked, birthDate, holidayDays, sickDays, position)
        {
        }

        //Methods
        public override String ToString()
        {
            return $"Admin: ID - {id}, Name - {name}, Email - {email}, Phonenumber - {phoneNumber}";
        }
    }
}
