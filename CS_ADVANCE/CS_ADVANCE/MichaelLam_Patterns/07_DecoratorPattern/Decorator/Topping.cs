using CS_ADVANCE.MichaelLam_Patterns._07_DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._07_DecoratorPattern.Decorator
{
    /// <summary>
    /// Nadzienie
    /// </summary>
    public abstract class Topping: IceCream
    {
        public Topping(IceCream c)
        {
            this.IceCream = c;
        }
        protected IceCream IceCream { get; set; }
    }
}
