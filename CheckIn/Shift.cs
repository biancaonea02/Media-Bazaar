using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class Shift
    {
        private int id;
        private String name;
        private String email;
        private DateTime date;
        private String shift;
        private String employeeStatus;

        public Shift(int id, String name, String email, DateTime dateTime, String shift)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.date = dateTime;
            this.shift = shift;
            this.employeeStatus = "ABSENT";
        }

        public int Id { get { return this.id; } }
        public String Name { get { return this.name; } }
        public String Email { get { return this.email; }  set { this.email = value; } }
        public DateTime Date { get { return this.date; } }
        public String Sh { get { return this.shift; } }
        public String EmployeeStatus { get { return this.employeeStatus; } set { this.employeeStatus = value; } }

        public override string ToString()
        {
            return $"Shift - Employee's name: {this.name}, Date: {this.date}, Moment of the day: {this.shift}";
        }
    }
}
