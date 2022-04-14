using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class User
    {
        //instance variables

        protected String name;
        protected int id;
        protected String gender;
        protected string password;
        protected String email;
        protected String address;
        protected String phoneNumber;
        protected double hourlyWage;
        protected double hoursWorked;
        protected DateTime birthDate;
        protected int holidayDays;
        protected int sickDays;

        public String Name { get { return this.name; } set { this.name = value; } }
        public int Id { get { return this.id; } }
        public string Password { get { return  this.password; } set { this.password = value; } }
        public DateTime BirthDate { get { return this.birthDate; } set { this.birthDate = value; } }
        public int HolidayDays { get { return this.holidayDays; }  set { this.holidayDays = value; } }
        public int SickDays { get { return this.sickDays; }  set { this.sickDays = value; } }

        public String Email
        {
            get { return email; }
            set
            {
                if (value.Contains('@'))
                {
                    email = value;
                }
                else
                {
                    throw new EmailFormatException("Email incorrect");
                }
            }
        }
        public String Gender { get { return this.gender; } set { this.gender = value; } }
        public String PhoneNumber { get { return this.phoneNumber; } set { this.phoneNumber = value; } }
        public String Address { get { return this.address; } set { this.address = value; } }
        public double HourlyWage { get { return this.hourlyWage; } set { this.hourlyWage = value; } }
        public double HoursWorked { get { return this.hoursWorked; } set { this.hoursWorked = value; } }

        public User(int id, string name, string password, string email, String gender, 
            string phoneNumber, string address, double hourlyWage, double hoursWorked, DateTime birthDate, int holidayDays, int sickDays)
        {
            this.name = name;
            this.id = id;
            this.email = email;
            this.password = password;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.hourlyWage = hourlyWage;
            this.hoursWorked = hoursWorked;
            this.birthDate = birthDate;
            this.holidayDays = holidayDays;
            this.sickDays = sickDays;
        }
      

        public override string ToString()
        {
            return $"{id},{name},{gender},{email},{phoneNumber},{address},{hourlyWage},{hoursWorked},{holidayDays},{sickDays},{birthDate}";
        }

    
    }
}
