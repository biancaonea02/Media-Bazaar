using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazaar.classes
{
    class ShiftAssignment
    {
        private DateTime startDate;
        private DateTime endDate;
        private List<Employee> employees;
        private List<Shift> shifts;
        private List<FreeDay> freeDays;
        private List<PrefferedShift> prefferedShifts;
        private IDictionary<Employee, int> employeesOrdered = new Dictionary<Employee, int>();
        List<String> employeeShifts = new List<String>();

        public ShiftAssignment()
        {
            employees = DatabaseHelper.GetAllEmployees();
            shifts = DatabaseHelper.GetAllShifts();
            prefferedShifts = DatabaseHelper.GetAllPrefferedShifts();
            freeDays = DatabaseHelper.GetAllFreeDays();

        }

        public bool ShiftOnFreeDay(string name, string email, DateTime date, string momentOfDay)
        {
            foreach (FreeDay f in DatabaseHelper.GetAllFreeDays())
            {
                if (date == f.Date && name == f.Name && email == f.Email && momentOfDay == f.Shift && f.SickDay == false && f.Status == "ACCEPTED")
                {
                    return true;
                }
                else if (date == f.Date && name == f.Name && email == f.Email && f.SickDay == true && f.Status == "ACCEPTED")
                {
                    return true;
                }
            }

            return false;
        }


        public void AutomaticScheduling(DateTime startDate1, PrefferedShiftsAdministration shiftAdmin)
        {

            //schedules for ONLY 1 week in advance
            List<Employee> all = DatabaseHelper.GetAllEmployees();

            foreach (Employee e in all)
            {
                DateTime startDate = startDate1;
                int maxHoursWeek = e.MaxMonthlyHours;
                List<String> prefferedShifts = shiftAdmin.GetPrefferedByEmployee(e);

                for (int contDays = 0; contDays <= 4; contDays++)
                {
                    String momentOfDay = null;
                    if (maxHoursWeek >= 3)
                    {
                        if (prefferedShifts[contDays] == "morning")
                        {
                            //check how many people are per this shift in that day
                            if (this.CheckEmployeesPerDayPerShift(startDate, prefferedShifts[contDays]))//true, means that we can schedule for this shift
                            {
                                //schedule for this shift
                                momentOfDay = "morning";
                                //verify if it's a free day
                                if (ShiftOnFreeDay(e.Name, e.Email, startDate, momentOfDay) == false)
                                {
                                    DatabaseHelper.AddShift(e.Name, e.Email, startDate, momentOfDay);
                                    maxHoursWeek = maxHoursWeek - 3;//-3 the shift that we just scheduled
                                }
                            }
                            else if (this.CheckEmployeesPerDayPerShift(startDate, "afternoon"))
                            {

                                //schedule for this shift
                                momentOfDay = "afternoon";
                                if (ShiftOnFreeDay(e.Name, e.Email, startDate, momentOfDay) == false)
                                {
                                    DatabaseHelper.AddShift(e.Name, e.Email, startDate, momentOfDay);
                                    maxHoursWeek = maxHoursWeek - 3;//-3 the shift that we just scheduled
                                }

                            }
                            else
                            {
                                //no scheduling
                            }


                        }


                        if (prefferedShifts[contDays] == "afternoon")
                        {
                            //check how many people are per this shift in that day
                            if (this.CheckEmployeesPerDayPerShift(startDate, prefferedShifts[contDays]))//true, means that we can schedule for this shift
                            {
                                //schedule for this shift
                                momentOfDay = "afternoon";
                                if (ShiftOnFreeDay(e.Name, e.Email, startDate, momentOfDay) == false)
                                {
                                    DatabaseHelper.AddShift(e.Name, e.Email, startDate, momentOfDay);
                                    maxHoursWeek = maxHoursWeek - 3;//-3 the shift that we just scheduled
                                }

                            }
                            else if (this.CheckEmployeesPerDayPerShift(startDate, "morning"))
                            {

                                //schedule for this shift
                                momentOfDay = "morning";
                                if (ShiftOnFreeDay(e.Name, e.Email, startDate, momentOfDay) == false)
                                {
                                    DatabaseHelper.AddShift(e.Name, e.Email, startDate, momentOfDay);
                                    maxHoursWeek = maxHoursWeek - 3;//-3 the shift that we just scheduled
                                }

                            }
                            else if (this.CheckEmployeesPerDayPerShift(startDate, "evening"))
                            {

                                //schedule for this shift
                                momentOfDay = "evening";
                                if (ShiftOnFreeDay(e.Name, e.Email, startDate, momentOfDay) == false)
                                {
                                    DatabaseHelper.AddShift(e.Name, e.Email, startDate, momentOfDay);
                                    maxHoursWeek = maxHoursWeek - 3;//-3 the shift that we just scheduled
                                }

                            }
                            else
                            {
                                //no scheduling


                            }
                        }


                        if (prefferedShifts[contDays] == "evening")
                        {
                            //check how many people are per this shift in that day
                            if (this.CheckEmployeesPerDayPerShift(startDate, prefferedShifts[contDays]))//true, means that we can schedule for this shift
                            {
                                //schedule for this shift
                                momentOfDay = "evening";
                                if (ShiftOnFreeDay(e.Name, e.Email, startDate, momentOfDay) == false)
                                {
                                    DatabaseHelper.AddShift(e.Name, e.Email, startDate, momentOfDay);
                                    maxHoursWeek = maxHoursWeek - 3;//-3 the shift that we just scheduled
                                }

                            }
                            else if (this.CheckEmployeesPerDayPerShift(startDate, "afternoon"))
                            {

                                //schedule for this shift
                                momentOfDay = "aftrenoon";
                                if (ShiftOnFreeDay(e.Name, e.Email, startDate, momentOfDay) == false)
                                {
                                    DatabaseHelper.AddShift(e.Name, e.Email, startDate, momentOfDay);
                                    maxHoursWeek = maxHoursWeek - 3;//-3 the shift that we just scheduled
                                }

                            }
                            else
                            {
                                //no scheduling

                            }

                        }

                    }
                    startDate = startDate.AddDays(1);
                }
            }

        }
       

        private bool CheckEmployeesPerDayPerShift(DateTime date, String shift)
        {
            //TODO
            //every day, 8 employees per shift per day

            List<Shift> allShifts = DatabaseHelper.GetAllShifts();
            int contEmployeesPerDayPerShift = 0;
            foreach (Shift s in allShifts)
            {
                if (s.Date == date && s.Sh == shift)
                {
                    contEmployeesPerDayPerShift++;
                }
            }
            if (contEmployeesPerDayPerShift < 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CalculateWorkingHours(string email, DateTime month)
        {
            int hours = 0;
            foreach (Shift s in shifts)
                if (s.Email == email)
                {
                    if (s.Date.Month == month.Month)
                    {
                        hours += 3;
                    }
                }
            return hours;
        }

    }
}
