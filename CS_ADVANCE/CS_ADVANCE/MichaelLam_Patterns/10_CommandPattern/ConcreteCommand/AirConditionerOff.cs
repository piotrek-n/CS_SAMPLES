﻿using CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.AbstractCommand;
using CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.ConcreteCommand
{
    public class AirConditionerOff: ICommand
    {
        AirConditioner ac;
        public AirConditionerOff(AirConditioner ac)
        {
            this.ac = ac;   
        }

        public void Execute()
        {
            ac.TurnOff();
        }
    }
}
