using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class Department
    {
        private String name;
        private int requiredPersonel;

        public Department(String name, int requiredPersonel)
        {
            this.name = name;
            this.requiredPersonel = requiredPersonel;
        }

        public String Name { get { return this.name; } set { this.name = value; } }
        public int RequiredPersonel { get { return this.requiredPersonel; } set { this.requiredPersonel = value; } }

        public override string ToString()
        {
            return $"Name of department: {this.name}, required personel: {this.requiredPersonel}";
        }
    }
}
