using CS_ADVANCE.MichaelLam_Patterns._07_DecoratorPattern.Component;
using CS_ADVANCE.MichaelLam_Patterns._07_DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._07_DecoratorPattern.ConcreteDecorator
{
    /// <summary>
    /// Posypka
    /// </summary>
    public class Sprinkle: Topping
    {
        public Sprinkle(IceCream s):base(s)
        {

        }
        public override double Cost()
        {
            return 0.5 + IceCream.Cost();
        }
    }
}
