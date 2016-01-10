using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_Threading._19_SynchronizedContainers
{
    public static class SynchronizedContainers
    {
        private static MySynchronizedQueue<int> numbers = new MySynchronizedQueue<int>();
        private static Random rand = new Random();
        private const int NumThread = 3;
        private static int[] sums = new int[NumThread];

        public static void ProduceNumbers()
        {
            for (int i = 0; i < 25; i++)
            {
                int numToEnqueue = rand.Next(10);
                Console.WriteLine("Producing thread adding" + numToEnqueue + " to the queue.");
                //lock (numbers)
                {
                    numbers.Enqueue(numToEnqueue);
                }
                Thread.Sleep(rand.Next(1000));
            }
        }

        public static void SumNumbers(object threadNumber)
        {
            DateTime startTime = DateTime.Now;
            int mySum = 0;
            while ((DateTime.Now - startTime).Seconds < 10)
            {
                int numToSum = -1;
                lock (numbers.SyncRoot) //Trace race// Lock zakłada się na małą cześć, tak aby widać o co chodzi
                {
                    if (numbers.Count != 0)
                    {
                        numToSum = numbers.Dequeue();
                    }
                }
                if (numToSum != -1)
                {
                    mySum += numToSum;

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
    /// <summary>
    /// Można byłby tu zastosować wzorzec projektowy
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MySynchronizedQueue<T>
    {
        object baton = new object();

        Queue<T> theQ = new Queue<T>();

        public void Enqueue(T item)
        {
            lock(baton)
            theQ.Enqueue(item);
        }

        public T Dequeue()
        {
            lock (baton)
            return theQ.Dequeue();
        }

        public int Count
        {
            get 
            {
                lock (baton)
                return theQ.Count;
            }
        }
        public object SyncRoot
        {
            get { return baton; } //Gdy synchronizacja jest oparta o peracje tracimy atomowość operacji i należy zastosować synchronizacje opartą o jeden element
        }
    }
}
