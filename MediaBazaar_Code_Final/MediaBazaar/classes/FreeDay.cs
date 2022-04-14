using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class FreeDay
    {
        private int id;
        private String name;
        private String email;
        private DateTime date;
        private String shift;
        private String reason;
        private bool sick_day;
        private String status;

        public FreeDay(int id, String name, String email, DateTime date, String shift, String reason, bool sick_day, String status)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.date = date;
            this.shift = shift;
            this.reason = reason;
            this.sick_day = sick_day;
            this.status = status;
        }

        public int Id { get { return this.id; } }
        public String Name { get { return this.name; }}
        public String Email { get { return this.email; } }
        public String Shift { get { return this.shift; } }
        public DateTime Date { get { return this.date; } }
        public String Status { get { return this.status; } set { this.status = value; } }
        public String Reason { get { return this.reason; } }
        public bool SickDay { get { return this.sick_day; } }

        public override string ToString()
        {
            if (this.shift == null && this.sick_day == true)
            {
                return $"Employee's name: {this.name}, date: {this.date.ToShortDateString()}, type: sick day, reason: {this.reason}, status: {this.status}";
            }
            else if(this.sick_day == false && this.shift != null)
            {
                return $"Employee's name: {this.name}, , date: {this.date.ToShortDateString()}, type: {this.shift} shift off, reason: {this.reason}, status: {this.status}";

            }
            else
            {
                return "shift";
            }

        }
    }
}
