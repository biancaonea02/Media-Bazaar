using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    class ExistingDepartmentName : Exception
    {
        public ExistingDepartmentName(String messsage) : base(messsage) //exception thrown when the use tries to add a new department and the name is already taken
        {

        }
    }
}
