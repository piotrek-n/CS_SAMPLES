using CS_ADVANCE.MichaelLam_Patterns._06_IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._06_IteratorPattern.Aggregate
{
    public interface ISocialNetworking
    {
        IIterator CreateIterator();
    }
}
