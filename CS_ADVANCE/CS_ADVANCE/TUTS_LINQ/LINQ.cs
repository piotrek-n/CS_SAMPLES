using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE
{
    public static class TUTS_LINQ
    {
        public static void LinqCaller()
        {
            var sample = "I enjoy wrting uber-sofware C#";

            var result = from c in sample.ToLower()
                         where c == 'a' || c == 'e'
                         orderby c ascending 
                         select c;

            var result2 = from c in sample.ToLower()
                          where c == 'a' || c == 'e'
                          group c by c;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            foreach (var item in result2)
            {
                Console.WriteLine("{0} - {1}",item.Key,item.Count());
            }

            var people = new List<Person>
            {
            new Person(){FirstName = "John",LastName="Deo",Age=25},
            new Person(){FirstName = "Jane",LastName="Deo",Age=25},
            new Person(){FirstName = "John",LastName="Williams",Age=26},
            new Person(){FirstName = "John",LastName="Ann",Age=10},
            new Person(){FirstName = "John",LastName="Deo",Age=10}
            };

            var result3 = from p in people
                          where p.Age < 30
                          orderby p.LastName
                          select p;
            foreach (var item in result3)
            {
                Console.WriteLine("{0}-{1}",item.FirstName,item.LastName);
            }

            var result4 = from p in people
                          where p.Age < 30
                          group p by p.LastName;

            foreach (var item in result4)
            {
                Console.WriteLine(item.Key + " - " + item.Count());
                foreach (var p in item)
                {
                    Console.WriteLine("{0} - {1}",p.LastName,p.FirstName);
                }
                
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}
