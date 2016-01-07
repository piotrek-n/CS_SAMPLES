using System;
using System.Threading;

namespace CS_ADVANCE.JamieKing_Threading._05_BasicThreadSynchronization
{
    public static class BasicThreadSynchronization
    {
        public static int count;
        private static object baton = new object();

        public static void Caller()
        {
            var thread1 = new Thread(IncrementCount);
            var thread2 = new Thread(IncrementCount);

            thread1.Start();
            thread2.Start();
        }

        private static void IncrementCount()
        {
            while (true)
            {
                lock (baton) //Żaden wątek nie może do tej sekcji dostać dopóki inny nie skończy swoich zadań
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
}