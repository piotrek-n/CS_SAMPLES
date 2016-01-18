using CS_ADVANCE.Dofactory_Patterns.AbstractFactory.Structural.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.Dofactory_Patterns.AbstractFactory.Structural.Factory
{

    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();

    }
}
