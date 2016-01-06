using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_ExpressionTrees._09_CS_WhyExpressionTreesAreCool_EntityFramework
{
    class MyContext: DbContext
    {
        public MyContext()//:base("MyConnectionInfo")
        {

        }

        public DbSet<Person> People { get; set; }
    }
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
    public static class _09_CS_WhyExpressionTreesAreCool_EntityFramework
    {
        public static void Caller()
        {
            var plumber = new MyContext();
            //foreach (Person person in plumber.People.AsEnumerable().Where( p=> p.Age > 30) ) //Pobierze wszystkie element dopiero później już po stronie kodu będzie sprawdzał warunek
            foreach (Person person in plumber.People.Where( p=> p.Age > 30) ) //Where jest Queryable // Generuj SQL już z klauzulą WHERE
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }
    }
}
