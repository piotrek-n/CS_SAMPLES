using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_ADVANCE.MichaelLam_Patterns._12_CompositePattern
{
    abstract class EmployeeComponent
    {
        public string Name { private set; get; }
        public EmployeeComponent(string name)
        {
            this.Name = name;
        }

        public virtual void PrintSupervisiorOf(int spacing)
        {
            for (int counter = 0; counter < spacing; counter++)
            {
                Console.WriteLine(" ");
            }
            Console.WriteLine(Name);
        }
    }
}
