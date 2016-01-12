using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam._04_SingletonPattern
{
    public static class _04_SingletonPattern
    {
        public static void Caller()
        {
            Logger.GetInstane().WriteToFile();
        }
    }

    public class Logger
    {
        private static Logger logger = null;
        private Logger()
        {

        }

        public static Logger GetInstane()
        {
            if (logger == null)
                logger = new Logger();

            return logger;
        }

        public void WriteToFile()
        {
            Console.WriteLine("Write to file");
        }
    }


}
