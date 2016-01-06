using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_ForeachCast
{
    class Base { }
    class Derived : Base { }
    public static class ForeachCast
    {
        public static void ForeachCastCaller()
        {
            Base b = new Base();
            Derived d = b as Derived;

            Console.WriteLine(d == null);
        }
    }
}
