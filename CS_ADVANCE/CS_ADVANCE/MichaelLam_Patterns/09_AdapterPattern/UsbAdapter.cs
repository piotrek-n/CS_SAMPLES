using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._09_AdapterPattern
{
    public class UsbAdapter
    {
        Mouse mouse = new Mouse();
        public void ConnectA()
        {
            Console.WriteLine("UsbAdapter ConnectA");
            mouse.ConnectB();
            Console.WriteLine("UsbAdapter ConnectA");
        }
    }
}
