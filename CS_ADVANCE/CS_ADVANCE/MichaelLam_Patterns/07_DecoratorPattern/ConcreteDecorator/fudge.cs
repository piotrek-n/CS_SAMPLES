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
    /// Polewa lukrowa pomoże być dodana do róznych lodów,
    /// </summary>
    public class Fudge:Topping
    {
        public Fudge(IceCream c):base(c)
        {
                
        }
        public override double Cost()
        {
            return 0.25 + IceCream.Cost();
        }
    }
}
