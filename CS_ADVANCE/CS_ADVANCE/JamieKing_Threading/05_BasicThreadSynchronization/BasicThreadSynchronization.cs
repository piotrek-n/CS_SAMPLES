using System;
using System.Threading;

namespace CS_ADVANCE.JamieKing_Threading._05_BasicThreadSynchronization
{
    public static class BasicThreadSynchronization
    {

        private static object baton = new object();
        static Random rand = new Random();
        public static void Caller()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(UseRestroomStall).Start();
            }
        }

        private static void UseRestroomStall()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "trying to obtain the bathroom stall..");

            lock (baton)
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "obtained the lock. Doing the bussines");
                Thread.Sleep(rand.Next(2000));
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "leaving the stall..");
            }

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "... is leaving the restaurant.");
        }
    }
}