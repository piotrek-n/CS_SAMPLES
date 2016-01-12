using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam._02_StrategyPattern
{
    public static class StrategyPattern
    {
        public static void Caller()
        {
            IWeapon weapon = null;
            Character mike = new Character();

            while (true)
            {
                Console.WriteLine("Choose weapon (1=Sword, 2=Axe, 3=Club)");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        weapon = new Sword();
                        break;
                    case "2":
                        weapon = new Axe();
                        break;
                    case "3":
                        weapon = new Club();
                        break;
                    default:
                        break;
                }

                mike.SetWeapon(weapon);
                mike.Attack();
            }
        }
    }
    public interface IWeapon
    {
        void Use();
    }

    public class Sword:IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Using Sword!");
        }
    }
    public class Axe : IWeapon
    {

        public void Use()
        {
            Console.WriteLine("Using Axe!");
        }
    }
    public class Club : IWeapon
    {

        void IWeapon.Use()
        {
            Console.WriteLine("Using Club!");
        }
    }
    /// <summary>
    /// Context class
    /// </summary>
    public class Character 
    {
        private IWeapon weapon;

        public void SetWeapon(IWeapon newWeapon)
        {
            weapon = newWeapon;
        }

        public void Attack()
        {
            weapon.Use();
        }
    }

}
