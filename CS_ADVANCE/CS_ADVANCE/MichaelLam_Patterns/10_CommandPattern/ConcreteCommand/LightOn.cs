using CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.AbstractCommand;
using CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.Reciver;
using System;

namespace CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.ConcreteCommand
{
    public class LightOn : ICommand
    {
        Light light;
        public LightOn(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }
    }
}