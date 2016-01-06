using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_ExpressionTrees._10_CS_BuildingQueriesAtRuntime
{
    class MyContext : DbContext
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

    public static class _10_CS_BuildingQueriesAtRuntime
    {
        public static void Caller()
        {
            var plumber = new MyContext();
            IQueryable<Person> people = plumber.People;

            var randy = new Random();

            Func<bool> randomBool = () => randy.Next() % 2 == 0;

            Console.WriteLine(people);
            if (randomBool()) {
                people = people.Where(p => p.Age > 30);
                Console.WriteLine(people);
            }

            if (randomBool())
            {
                people = people.OrderBy(p => p.FirstName);
                Console.WriteLine(people);
            }

            var enResult = people.Select(p => new { p.FirstName, p.LastName });
            Console.WriteLine(enResult);

        }
    }
}
