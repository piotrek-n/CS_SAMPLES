using System;
using System.Threading;

namespace CS_ADVANCE.JamieKing_Threading._03_ForegroundThreadsAndThreadIDs
{
    internal class ForegroundThreadsAndThreadIDs
    {
        public static void Caller()
        {
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                var thread = new Thread(DifferentMethod);
                thread.IsBackground = true; //Watek nie jest zbyt istoty, dlatego po zakonczeniu wątku głownego zostanie zniszczony
                thread.Start(i);
            }

            Console.WriteLine("Leaving Main");
        }

        private static void DifferentMethod(object threadID)
        {
            while (true)
            {
                Console.WriteLine("My Name:" + threadID + " Thread.CurrentThread.ManagedThreadId :" + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}