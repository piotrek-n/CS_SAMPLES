using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._06_IteratorPattern.Iterator
{
    public interface IIterator
    {
        void First(); //Reset back to first element
        string Next(); //Get next
        bool IsDone(); //End of collection chceck
        string CurrentItem(); // Get current item
    }
}
