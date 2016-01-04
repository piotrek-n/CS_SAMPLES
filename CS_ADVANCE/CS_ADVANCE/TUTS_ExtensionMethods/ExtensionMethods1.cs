using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.TUTS_ExtensionMethods
{
    public static class ExtensionMethods1
    {
        public static void ExtensionMethods1Caller()
        {
            var person = new Person() { Name = "John", Age = 11 };
            var person2 = new Person() { Name = "Sally", Age = 11 };
            person.SayHello(person2);

        }
    }

    public static class Extenstions
    {
        public static void SayHello(this Person p,Person person)
        {
            Console.WriteLine("Hi from {0} to {1}", p.Name,person.Name);
        }
    } 



    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
