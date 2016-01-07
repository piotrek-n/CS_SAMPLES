using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_Threading._01_HelloThreading
{
    public static class HelloThreading
    {
        public static void Caller()
        {
            var thread = new Thread(DifferentMethod);
            thread.Start();
        }

        private static void DifferentMethod()
        {
            Console.WriteLine("My Name");
        }
    }
}
