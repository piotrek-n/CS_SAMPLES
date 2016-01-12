using CS_ADVANCE.MichaelLam_Patterns._07_DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._07_DecoratorPattern.ConcreteComponent
{
    public class Vanilla: IceCream
    {
        public override double Cost()
        {
            return 1.0;
        }
    }
}
