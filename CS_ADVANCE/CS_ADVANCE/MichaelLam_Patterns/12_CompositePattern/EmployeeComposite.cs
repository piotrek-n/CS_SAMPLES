using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._12_CompositePattern
{
    class EmployeeComposite: EmployeeComponent
    {
        IList<EmployeeComponent> employees;

        public void AddEmployee(EmployeeComponent e)
        {
            employees.Add(e);
        }
        public void RemoveEmployee(EmployeeComponent e)
        {
            employees.Remove(e);
        }
    }
}
