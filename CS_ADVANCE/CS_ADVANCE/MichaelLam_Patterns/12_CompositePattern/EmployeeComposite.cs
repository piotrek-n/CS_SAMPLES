using System.Collections.Generic;

namespace CS_ADVANCE.MichaelLam_Patterns._12_CompositePattern
{
    internal class EmployeeComposite : EmployeeComponent
    {
        private IList<EmployeeComponent> employees;

        public EmployeeComposite(string name)
            : base(name)
        {
            employees = new List<EmployeeComponent>();
        }

        public void AddEmployee(EmployeeComponent e)
        {
            employees.Add(e);
        }

        public void RemoveEmployee(EmployeeComponent e)
        {
            employees.Remove(e);
        }

        public override void PrintSupervisiorOf(int spacing)
        {
            base.PrintSupervisiorOf(spacing);

            foreach (EmployeeComponent e in employees)
            {
                e.PrintSupervisiorOf(spacing + 1);
            }
        }
    }
}