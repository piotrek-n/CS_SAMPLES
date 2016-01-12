using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam._05_ObserverPattern.Observer
{
    public class User : ISubsciber
    {
        public void Notify()
        {
            Console.WriteLine("User has been update about a new video!");
        }
    }
}
