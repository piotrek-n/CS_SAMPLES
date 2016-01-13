using CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.ConcreteCommand;
using CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.Invoker;
using CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern.Reciver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._10_CommandPattern
{
    public static class _10_CommandPattern
    {
        /// <summary>
        /// Client ze schematu
        /// </summary>
        public static void Caller()
        {
            //Existing stuff in the house
            Light bedRooomLights = new Light();
            AirConditioner acForEntireHouse = new AirConditioner();

            //Create the On commands
            LightOn turnBedRoomLightOn = new LightOn(bedRooomLights);
            AirConditionerOn turnOnAC = new AirConditionerOn(acForEntireHouse);

            //Create the Off commands
            LightOff turnBedRoomLightOff = new LightOff(bedRooomLights);
            AirConditionerOff turnOffAC = new AirConditionerOff(acForEntireHouse);

            //Add the On to the remote
            RemoteController remote = new RemoteController();
            remote.InsertNewOnCommand(turnBedRoomLightOn);
            remote.InsertNewOnCommand(turnOnAC);

            remote.InsertNewOffCommand(turnBedRoomLightOff);
            remote.InsertNewOffCommand(turnOffAC);

            //Turn On the lights and AC
            remote.PressButtonOn(0); //Light
            remote.PressButtonOn(1); //AC

            //Turn Off the lights and AC
            remote.PressButtonOff(0); //Light
            remote.PressButtonOff(1); //AC



        }
    }
}
