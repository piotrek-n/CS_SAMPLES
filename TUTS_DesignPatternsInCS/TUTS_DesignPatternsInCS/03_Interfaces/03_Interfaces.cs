using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTS_DesignPatternsInCS._03_Interfaces
{
    public static class _03_Interfaces
    {
        public static void Caller()
        {
            //StreamWriter implement IDisposable
            //using (var writer = new StreamWriter())
            //{
            //    writer.Dispose();
            //}

            var app = new HandyDandyApplication();
            app.DisplayUsers(Console.Out);
            Console.Read();
        }
    }
}
