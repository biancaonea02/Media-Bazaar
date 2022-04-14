using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class Employee : User, IComparable<Employee>
    {
        //instance variables
        String department;
        private int maxMonthlyHours;
        private string prefferedShift;

        //constructor 
        public Employee(int id, string name, string password, string email, String gender, string phoneNumber, string address, double hourlyWage, double hoursWorked, DateTime birthDate, int holidayDays, int sickDays, String department, int maxMonthlyHours, string prefferedShift) 
            : base(id, name, password, email, gender, phoneNumber, address, hourlyWage, hoursWorked, birthDate, holidayDays, sickDays)
        {
            this.department = department;
            this.maxMonthlyHours = maxMonthlyHours;
            this.prefferedShift = prefferedShift;
        }


        //properties
        public String Department { get { return this.department; } set { this.department = value; } }
        public int MaxMonthlyHours { get { return maxMonthlyHours; } set { maxMonthlyHours = value; }}
        public string PrefferedShift{ get { return prefferedShift; } set { prefferedShift = value; }}

        public int CompareTo(Employee other)
        {
            return this.HoursWorked.CompareTo(other.HoursWorked);
        }
    }
}
