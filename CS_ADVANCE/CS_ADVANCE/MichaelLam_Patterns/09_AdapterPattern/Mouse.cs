using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._09_AdapterPattern
{
    /// <summary>
    /// Adaptee
    /// </summary>
    public class Mouse
    {
        public Mouse()
        {

        }

        public void ConnectB()
        {
            Console.WriteLine("Mouse ConnectB");
        }
    }
}
