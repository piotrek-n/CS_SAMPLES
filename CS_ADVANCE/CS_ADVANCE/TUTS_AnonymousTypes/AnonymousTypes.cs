using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.TUTS_AnonymousTypes
{
    public static class AnonymousTypes
    {
        public static void AnonymousTypesCaller()
        {
            var people = new List<Person>
            {
            new Person(){FirstName = "John",LastName="Deo",Age=20},
            new Person(){FirstName = "Jane",LastName="Deo",Age=30},
            new Person(){FirstName = "John",LastName="Williams",Age=15},
            new Person(){FirstName = "John",LastName="Ann",Age=17},
            new Person(){FirstName = "John",LastName="Deo",Age=10}
            };

            var result = from p in people
                         where p.LastName == "Deo"
                         select new {fName=p.FirstName,lName=p.LastName }; //Only props! // Only readonly
            foreach (var item in result)
            {
                Console.WriteLine(item.fName + " - " + item.lName);
            }

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }

    }
}
