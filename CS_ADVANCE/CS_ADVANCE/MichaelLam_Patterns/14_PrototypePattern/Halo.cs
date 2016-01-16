using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._14_PrototypePattern
{
    public class Halo: XBoxGame
    {
        public Halo(string title)
        {
            Title = title;
        }

        public override XBoxGame Clone()
        {
            return (Halo)this.MemberwiseClone();
        }
    }
}
