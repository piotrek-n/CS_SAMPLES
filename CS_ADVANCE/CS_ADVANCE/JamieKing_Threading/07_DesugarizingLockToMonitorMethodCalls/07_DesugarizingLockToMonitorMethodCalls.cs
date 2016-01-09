using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_Threading._07_DesugarizingLockToMonitorMethodCalls
{
    

    public static class _07_DesugarizingLockToMonitorMethodCalls
    {
        static object baton = new object();

        public static void Caller()
        {
            Console.WriteLine("07_DesugarizingLockToMonitorMethodCalls");
            bool lockTacken = false;
            //lock (baton) 

            //Monitor jest tym samym, co lock
            Monitor.Enter(baton,ref lockTacken);
            try
            {
                Console.WriteLine("Got the baton");
            }
            finally
            {
                if(lockTacken)
                Monitor.Exit(baton);
            }

            //lock
            //lock (baton)
            //{
            //    Console.WriteLine("Got the baton");
            //}


        }
    }
}
