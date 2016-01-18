using CS_ADVANCE.Dofactory_Patterns.AbstractFactory.Structural.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.Dofactory_Patterns.AbstractFactory.Structural
{
    public static class AbstractFactoryCaller
    {
        public static void Caller()
        { 
            Client c = new Client(new ConcreteFactory1());
        }
    }
}
