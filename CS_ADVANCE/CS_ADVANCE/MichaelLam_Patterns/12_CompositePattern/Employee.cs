using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._12_CompositePattern
{
    class Employee: EmployeeComponent
    {
        public Employee(string name):base(name)
        {

        }

        public override void PrintSupervisiorOf(int spacing)
        {
            base.PrintSupervisiorOf(spacing);
        }
    }
}