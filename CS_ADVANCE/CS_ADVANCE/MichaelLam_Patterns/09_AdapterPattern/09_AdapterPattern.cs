using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._09_AdapterPattern
{
    /// <summary>
    /// Adaptować 1 interfejs w drugi
    /// </summary>
    public static class _09_AdapterPattern
    {
        public static void Caller()
	        {
		       UsbAdapter usb = new UsbAdapter();
               usb.ConnectA(); 
	        }
    }
}
