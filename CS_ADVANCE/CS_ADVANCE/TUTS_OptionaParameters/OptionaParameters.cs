using System;

namespace CS_ADVANCE.TUTS_OptionaParameters
{
    public static class OptionaParameters
    {
        public static void OptionaParametersCaller()
        {
            PrintData("john", "doe", 18);
            PrintData(firstName: "john", age: 18); //Skip parameteers
        }

        //private static void PrintData(string firstName, string LastName, int age)
        //{
        //    Console.WriteLine("{0} {1} is {2} years old.", firstName, LastName, age);
        //}

        private static void PrintData(string firstName, string LastName=null, int age=0)
        {
            Console.WriteLine("{0} {1} is {2} years old.", firstName, LastName, age);
        }
    }
}