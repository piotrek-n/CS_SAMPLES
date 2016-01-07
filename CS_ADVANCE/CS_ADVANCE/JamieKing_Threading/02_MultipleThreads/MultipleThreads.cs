using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_Threading._02_MultipleThreads
{
    public static class MultipleThreads
    {
        public static void Caller()
        {
            for (int i = 0; i < 3; i++)
            {
                var thread = new Thread(DifferentMethod);
                thread.Start(i); 
            }

            while (true)
            {
                Console.WriteLine("Hello from Main()");
            }
        }

        private static void DifferentMethod(object threadID)
        {
            while (true)
            {
                Console.WriteLine("My Name:"+ threadID); 
            }
        }
    }
}
