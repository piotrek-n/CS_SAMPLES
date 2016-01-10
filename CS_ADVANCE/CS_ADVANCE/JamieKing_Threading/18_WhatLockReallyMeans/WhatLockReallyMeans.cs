using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_Threading._18_WhatLockReallyMeans
{
    class BathroomStall
    {
        internal void BeUsed(int p)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("being used by: " + p);
                Thread.Sleep(500);
            }
        }
    }
    public static class WhatLockReallyMeans
    {
        static BathroomStall stall = new BathroomStall();
        public static void Caller()
        {
            for (int i = 0; i < 3; i++)
            {
                new Thread(RegularUsers).Start();
            }
            new Thread(TheWeirdUsers).Start();
        }
        static void RegularUsers()
        {
            lock (stall)
            {
                stall.BeUsed(Thread.CurrentThread.ManagedThreadId);
            }
        }
        static void TheWeirdUsers()
        {
            Monitor.Enter(stall); //To obiekt ma pole, które wskazuje który watek w daje chwili ma do niego dostęp.
            stall.BeUsed(99);
            Monitor.Exit(stall);
        }
    }
}
