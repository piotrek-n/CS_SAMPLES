using CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.AbstractCommand;
using CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.ConcreteCommand
{
    public class LightOff:ICommand 
    {
        Light light;
        public LightOff(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }
    }
}
