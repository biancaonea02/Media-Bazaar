using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class PrefferedShiftsAdministration
    {
        private List<PrefferedShift> allPrefferedShifts;

        public PrefferedShiftsAdministration()
        {
            this.allPrefferedShifts = DatabaseHelper.GetAllPrefferedShifts();
        }
        public  List<String> GetPrefferedByEmployee(Employee employee)
        {
            foreach(PrefferedShift p in allPrefferedShifts)
            {
                if(employee.Email == p.EmailEmployee && employee.Email == p.EmailEmployee)
                {
                    return p.GetAllPrefferedShiftWeekdays();
                }
            }
            return null;
        }
        public PrefferedShift[] GetAllPrefferedShifts()
        {
            return this.allPrefferedShifts.ToArray();
        }
    }
}
