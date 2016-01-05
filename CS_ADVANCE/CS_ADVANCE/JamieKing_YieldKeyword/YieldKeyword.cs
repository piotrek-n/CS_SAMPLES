using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_YieldKeyword
{
    public static class YieldKeyword
    {
        static Random rand = new Random();

        static IEnumerable<int> GetRandomNumbers(int count)
        { 
             //List<int> ints = new List<int>();
             //for (int i = 0; i < count; i++)
             //{
             //    ints.Add(rand.Next());
             //}
             //return ints;

            List<int> ints = new List<int>();
            for (int i = 0; i < count; i++)
                yield return rand.Next();

        }

        public static void YieldKeywordCaller()
        {
            foreach (var num in GetRandomNumbers(10)) //przy kazdym przejsciu znów wejdzie w GetRandomNumbers w pętle
            {
                Console.WriteLine(num);
            }
        }
    }
}
