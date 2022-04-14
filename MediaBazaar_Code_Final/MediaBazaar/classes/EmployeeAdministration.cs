using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class EmployeeAdministration
    {
        public String Name { get; private set; }

        //constructors
        public EmployeeAdministration(String name)
        {
            this.Name = name;
        }

        //methods

        public Manager GetManagerById(int id)
        {
            foreach (Manager m in DatabaseHelper.GetAllManagers())
            {
                if (m.Id == id)
                { return m; }
            }
            return null;
        }
        public Employee GetEmployeeById(int id)
        {
            foreach (Employee e in DatabaseHelper.GetAllEmployees())
            {
                if (e.Id == id)
                { return e; }
            }
            return null;
        }
        public Employee GetEmployeeByNameEmail(string name, string email)
        {
            foreach (Employee e in DatabaseHelper.GetAllEmployees())
            {
                if (e.Name == name && e.Email == email)
                { return e; }
            }
            return null;
        }
        public Manager GetUserByEmailPassword(string email, string password)
        {
            foreach (Manager m in DatabaseHelper.GetAllManagers())
            {
                if (m.Email == email && m.Password == password)
                { return m; }
            }
            return null;
        }

        public List<Manager> GetAllManagers()
        {
            return DatabaseHelper.GetAllManagers();
        }
        public List<Employee> GetAllEmployees()
        {
            return DatabaseHelper.GetAllEmployees();
        }

        public List<Employee> GetBestEmployeesByHoursWorked()
        {
            DatabaseHelper.GetAllEmployees().Sort();
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 5; i++)
            {
                employees.Add(DatabaseHelper.GetAllEmployees()[i]);
            }
            return employees;
        }

        public int NrFemaleEmployees()
        {
            List<Employee> temp = new List<Employee>();

            foreach (Employee e in DatabaseHelper.GetAllEmployees())
            {
                if (e.Gender == "FEMALE") { temp.Add(e); }
            }
            return temp.Count();
        }

        public int NrOfEmployeesPerDepartment(String department)
        {
            int nr = 0;
            foreach (Employee e in DatabaseHelper.GetAllEmployees())
            {
                if (e.Department == department)
                {
                    nr++;
                }
            }

            return nr;
        }

        public int NrShiftsEmployee(Employee e, DateTime start)
        {
            int nr = 0;
            DateTime end = start.AddDays(6);
            foreach (Shift sh in DatabaseHelper.GetAllShifts())
            {
                if (sh.Name == e.Name && sh.Email == e.Email && sh.Date >= start && sh.Date <= end)
                {
                    nr++;
                }
            }

            return nr;
        }

        public List<Employee> EmployeesFromDepartment(String department)
        {
            List<Employee> temp = new List<Employee>();

            foreach (Employee e in DatabaseHelper.GetAllEmployees())
            {
                if (e.Department == department)
                {
                    temp.Add(e);
                }
            }

            return temp;
        }

        public Department GetDepartmentByName(String name)
        {
            foreach (Department d in DatabaseHelper.GetAllDepartments())
            {
                if (d.Name == name)
                {
                    return d;
                }
            }

            return null;
        }

        public int NrFemaleEmployeesDepartment(Department d)
        {
            int nr = 0;
            foreach (Employee e in DatabaseHelper.GetAllEmployees())
            {
                if (e.Department == d.Name && e.Gender == "FEMALE")
                {
                    nr++;
                }
            }

            return nr;
        }

        public int NrShiftsOfLastWeekByStatusOfEmployee(Employee e, String status, DateTime start)
        {
            int nrShifts = 0;
            foreach(Shift s in DatabaseHelper.GetAllShifts())
            {
                if(s.Email == e.Email && s.Name == e.Name && s.Date >= start && s.Date <= start.AddDays(4))
                {
                    if(s.EmployeeStatus == status)
                    {
                        nrShifts++;
                    }
                }
            }
            return nrShifts;
        }



    }
}
