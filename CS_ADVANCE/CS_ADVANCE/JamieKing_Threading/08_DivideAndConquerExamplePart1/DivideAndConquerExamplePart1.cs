using System;
using System.Diagnostics;

namespace CS_ADVANCE.JamieKing_Threading._08_DivideAndConquerExamplePart1
{
    /// <summary>
    /// Dziel i rządź
    /// </summary>
    public static class DivideAndConquerExamplePart1
    {
        private static byte[] values = new byte[500000000];

        private static void GenerateInts()
        {
            var rand = new Random(987);
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = (byte)rand.Next(10);
            }
        }

        public static void Caller()
        {
            GenerateInts();
            Console.WriteLine("Symming...");
            long total = 0;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < values.Length; i++)
                total += values[i];
            Console.WriteLine("Total value is:" + total);
            Console.WriteLine("Time to sum: " + watch.Elapsed);
        }
    }
}