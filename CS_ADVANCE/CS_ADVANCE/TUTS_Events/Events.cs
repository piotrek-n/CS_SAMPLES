using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.TUTS_Events
{
    public static class Events
    {
        public static void CallerEvents()
        {
            var tower = new ClockTower();
            var john = new Person("John", tower);

            tower.ChimeFivePM();
        }
    }
    public class ClockTowerEventArgs : EventArgs
    {
        public int Time { get; set; }

    }
    public class Person
    {
        private string _name;
        private ClockTower _clockTower;  

        public Person(string name,ClockTower tower) 
        {
            _name = name;
            _clockTower = tower;

            _clockTower.Chime += (object sender, ClockTowerEventArgs args) => { Console.WriteLine("{0} heard the clock chime at {1}", _name,args.Time); };
        }

    }
    public delegate void ChimeEventHandler(object sender, ClockTowerEventArgs args);

    public class ClockTower
    {
        public event ChimeEventHandler Chime;
        public void ChimeFivePM()
        {
            Chime(this, new ClockTowerEventArgs() { Time =  17});
        }

        public void ChimeSixAM()
        {
            Chime(this, new ClockTowerEventArgs() { Time = 16 });
        }
    }
}
