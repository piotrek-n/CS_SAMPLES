using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_ADVANCE.Dofactory_Patterns.FactoryMethod.Structural
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    public abstract class Creator
    {

        public abstract Product FactoryMethod();

    }
}
