using CS_ADVANCE.MichaelLam_Patterns._07_DecoratorPattern.Component;
using CS_ADVANCE.MichaelLam_Patterns._07_DecoratorPattern.ConcreteComponent;
using CS_ADVANCE.MichaelLam_Patterns._07_DecoratorPattern.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._07_DecoratorPattern
{
    public static class _07_DecoratorPattern
    {   //https://dotnetpage.wordpress.com/2013/08/06/dekorator-wzorzec-strukturalny/
        public static void Caller()
        {
            IceCream iceCream = new Chocolate();
            iceCream = new Sprinkle(iceCream);
            iceCream = new Fudge(iceCream);

            Console.WriteLine(iceCream.Cost());
            Console.ReadKey();

        }
    }
}
