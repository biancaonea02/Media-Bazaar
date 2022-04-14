using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class PrefferedShift
    {

        //instance variables
        int idPrefferedShifts;
        private List<String> prefferedShiftsWeekdays;
        private String emailEmployee;
        //properies
        public int IdPrefferedShift { get { return this.idPrefferedShifts; } }
        public String EmailEmployee { get { return this.emailEmployee; } }
        //constructor
        public PrefferedShift(int idPrefferedShifts, String emailEmployee, List<String> prefferedShifts)
        {
            this.idPrefferedShifts = idPrefferedShifts;
            this.prefferedShiftsWeekdays = prefferedShifts;
            this.emailEmployee = emailEmployee;
        }
        //methods
        public bool UpdatePrefferedShifts(List<String> newPreffered)
        {
            this.prefferedShiftsWeekdays = newPreffered;
            return true;
        }
        public void AddPrefferedShift(String shiftWeekday)
        {
            this.prefferedShiftsWeekdays.Add(shiftWeekday);
        }
        public List<String> GetAllPrefferedShiftWeekdays()
        {
            return this.prefferedShiftsWeekdays;
        }

    }
}
