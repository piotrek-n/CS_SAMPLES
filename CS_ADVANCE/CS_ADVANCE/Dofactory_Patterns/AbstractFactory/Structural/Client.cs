using CS_ADVANCE.Dofactory_Patterns.AbstractFactory.Structural.Product;
using CS_ADVANCE.Dofactory_Patterns.AbstractFactory.Structural.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.Dofactory_Patterns.AbstractFactory.Structural
{
    /// <summary>
    /// The 'Client' class. Interaction environment for the products.
    /// </summary>
    class Client
    {

        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        // Constructor
        public Client(CS_ADVANCE.Dofactory_Patterns.AbstractFactory.Structural.Factory.AbstractFactory factory)
        {           
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {

            _abstractProductB.Interact(_abstractProductA);

        }

    }
}
