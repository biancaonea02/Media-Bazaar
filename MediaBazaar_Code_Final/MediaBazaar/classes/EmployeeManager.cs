using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    class EmployeeManager : Manager
    {
        //constructor
        public EmployeeManager(int id, string name, String password, string email, String gender, string phoneNumber, string address, double hourlyWage, double hoursWorked, DateTime birthDate, int holidayDays, int sickDays, string position)
           : base(id, name, password, email, gender, phoneNumber, address, hourlyWage, hoursWorked, birthDate, holidayDays, sickDays, position)
        {
        }

        //Methods
        public override String ToString()
        {
            return $"Employee Manager: ID - {id}, Name - {name}, Email - {email}, Phonenumber - {phoneNumber}";
        }
    }
}
