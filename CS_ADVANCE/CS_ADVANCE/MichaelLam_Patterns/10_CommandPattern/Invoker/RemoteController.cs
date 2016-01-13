using CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.AbstractCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.Invoker
{
    public class RemoteController
    {
        private IList<ICommand> turnOnCommand = new List<ICommand>(); // AC On, Light On
        private IList<ICommand> turnOffCommand = new List<ICommand>();// AC Off, Light Off

        public void InsertNewOnCommand(ICommand command)
        {
            turnOnCommand.Add(command);
        }

        public void InsertNewOffCommand(ICommand command)
        {
            turnOffCommand.Add(command);
        }

        public void PressButtonOn(int buttonNumber)
        {
            turnOnCommand[buttonNumber].Execute();
        }

        public void PressButtonOff(int buttonNumber)
        {
            turnOffCommand[buttonNumber].Execute();
        }
    }
}
