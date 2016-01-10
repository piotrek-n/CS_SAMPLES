using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_Threading._09_DivideAndConquerExamplePart2
{
    public static class DivideAndConquerExamplePart2
    {
        static byte[] values = new byte[500000000];
        static long[] portionResults;
        static int portionSize;
        static void GenerateInts()
        {
            var rand = new Random(987);
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = (byte)rand.Next(10);
            }
        }
        /// <summary>
        /// Sumowanie wszystkich po paczce
        /// </summary>
        /// <param name="portionNumber"></param>
        static void SumYourPortion(object portionNumber)
        {
            long sum = 0;
            int portionNumberAsInt = (int)portionNumber;
            int baseIndex = portionNumberAsInt * portionSize;
            for (int i = baseIndex; 
                     i < portionNumberAsInt * portionSize + portionSize;
                     i++)
            {
                sum += values[i];
            }
            portionResults[portionNumberAsInt] = sum;
        }
        public static void Caller()
        {
            portionResults = new long[Environment.ProcessorCount];
            portionSize = values.Length / Environment.ProcessorCount;


            GenerateInts();
            Console.WriteLine("Summing...");
            long total = 0;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < values.Length; i++)
                total += values[i];
            Console.WriteLine("Total value is:" + total);
            Console.WriteLine("Time to sum: " + watch.Elapsed);

            watch.Reset();
            watch.Start();
            Thread[] threads = new Thread[Environment.ProcessorCount];
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                threads[i] = new Thread(SumYourPortion);
                threads[i].Start(i);
            }
            //Blokuje wątek wywołąjcy i czekamy na zakończenie, każdego wątku.
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                threads[i].Join();
            }
            long total2=0;
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                total2 += portionResults[i];
            }
            watch.Stop();
            Console.WriteLine("Total value is:" + total2);
            Console.WriteLine("Time to sum:" + watch.Elapsed);
        }
    }
}
