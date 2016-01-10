using System;
using System.Collections.Generic;
using System.Threading;

namespace CS_ADVANCE.JamieKing_Threading._13_ProducerConsumerThreadImplementationPart2
{
    public static class ProducerConsumerThreadImplementationPart2
    {
        private static Queue<int> numbers = new Queue<int>();
        private static Random rand = new Random();
        private const int NumThread = 3;
        private static int[] sums = new int[NumThread];

        public static void ProduceNumbers()
        {
            for (int i = 0; i < 25; i++)
            {
                int numToEnqueue = rand.Next(10);
                Console.WriteLine("Producing thread adding" + numToEnqueue + " to the queue.");
                numbers.Enqueue(numToEnqueue);
                Thread.Sleep(rand.Next(1000));
            }
        }

        public static void SumNumbers(object threadNumber)
        {
            DateTime startTime = DateTime.Now;
            int mySum = 0;
            while ((DateTime.Now - startTime).Seconds < 10)
            {
                if (numbers.Count != 0)
                {
                    int numToSum;
                    try
                    {
                        numToSum = numbers.Dequeue();
                    }
                    catch 
                    {
                        Console.WriteLine("thread# "  + threadNumber +" having an issue!");
                        throw;
                    }
                    Console.WriteLine("Consumin thread# " + threadNumber + " adding " + numToSum
                                      + " to its total sum making" + numToSum + "for the thread total.");
                }
            }

            sums[(int)threadNumber] = mySum;
        }

        public static void Caller()
        {
            var producingThread = new Thread(ProduceNumbers);
            producingThread.Start();

            Thread[] threads = new Thread[NumThread];

            for (int i = 0; i < NumThread; i++)
            {
                threads[i] = new Thread(SumNumbers);
                threads[i].Start(i);
            }
            for (int i = 0; i < NumThread; i++)
            {
                threads[i].Join();
            }
            int totalSum = 0;
            for (int i = 0; i < NumThread; i++)
            {
                totalSum += sums[i];
            }
            Console.WriteLine("Done adding. Total is :" + totalSum);
        }
    }
}