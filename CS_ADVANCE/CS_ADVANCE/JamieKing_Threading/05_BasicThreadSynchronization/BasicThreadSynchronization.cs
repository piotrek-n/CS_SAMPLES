using System;
using System.Threading;

namespace CS_ADVANCE.JamieKing_Threading._05_BasicThreadSynchronization
{
    public static class BasicThreadSynchronization
    {

        private static object baton = new object();

        public static void Caller()
        {

        }

        private static void UseRestroomStall()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "trying to obtain the bathroom stall..");

            lock (baton)
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}