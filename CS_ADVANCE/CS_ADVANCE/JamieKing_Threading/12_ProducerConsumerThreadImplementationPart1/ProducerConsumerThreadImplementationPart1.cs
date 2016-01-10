using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_Threading._12_ProducerConsumerThreadImplementationPart1
{
    public static class ProducerConsumerThreadImplementationPart1
    {
        static Queue<int> numbers = new Queue<int>();
        static Random rand = new Random();
        const int NumThread = 3;
        static int[] sums = new int[NumThread];

        public static void ProduceNumbers()
        {
            for (int i = 0; i < 25; i++)
            {
                int numToEnqueue = rand.Next(10);
                Console.WriteLine( "Producing thread adding" + numToEnqueue + " to the queue." );
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
                   int numToSum = numbers.Dequeue();
                   Console.WriteLine("Consumin thread adding " + numToSum 
                                     + " to its total sum making" + numToSum + "for the thread total." );
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
                threads[i].Start();
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
