using System;
namespace CS_ADVANCE.MichaelLam_Patterns._12_CompositePattern
{
    public static class _12_CompositePattern
    {
        public static void Caller()
        {
            //Prepere
            Employee cathreine = new Employee("Catherine");
            Employee david = new Employee("David");

            EmployeeComposite mark = new EmployeeComposite("mark");
            EmployeeComposite kathy = new EmployeeComposite("kathy");
            EmployeeComposite mike= new EmployeeComposite("mike");

            Employee gage = new Employee("Gage");
            Employee reg = new Employee("Reggie");

            //Start
            //Lori is th boss of Mark and Kathy
            EmployeeComposite lori = new EmployeeComposite("Lori"); //root
            lori.AddEmployee(mark);
            lori.AddEmployee(kathy);

            //But Mark is the boss of Catherine, David
            mark.AddEmployee(cathreine);
            mark.AddEmployee(david);

            kathy.AddEmployee(mike);

            mike.AddEmployee(gage);
            mike.AddEmployee(reg);

            lori.PrintSupervisiorOf(0);
            kathy.PrintSupervisiorOf(0);

            Console.ReadKey();
        }
    }
}