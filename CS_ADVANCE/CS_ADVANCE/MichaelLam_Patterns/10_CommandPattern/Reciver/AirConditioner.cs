using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.Reciver
{
    public class AirConditioner
    {
        public void TurnOn()
        {
            Console.WriteLine("AirConditioner are on!");
        }

        public void TurnOff()
        {
            Console.WriteLine("AirConditioner are off!");
        }

        public void IncreaseTemp()
        {
            Console.WriteLine("Increasing Temperature");
        }

        public void DecreaseTemp()
        {
            Console.WriteLine("Decreasing Temperature");
        }
    }
}
