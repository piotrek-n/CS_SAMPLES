using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_Threading._04_ThreadSynchronizationIssue
{
    public static class ThreadSynchronizationIssue
    {
        public static int count;
        public static void Caller()
        {
            var thread1 = new Thread(IncrementCount);
            var thread2 = new Thread(IncrementCount);

            thread1.Start();
            thread2.Start();

        }
        static void IncrementCount()
        {
            while (true)
            {
                int temp = count; // Jest to operacja nie atomiczna // Wiele wątków może odzytać ta wartość, a dopiero póżniej możę ją modyfikwoać -> tak jak poniżej
                Thread.Sleep(1000);
                count = temp + 1;
                Console.WriteLine(
                    "Thread ID" + Thread.CurrentThread.ManagedThreadId +
                    " increamented count to " + count);
            }
        }
    }
}
