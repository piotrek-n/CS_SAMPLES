using CS_ADVANCE.MichaelLam_Patterns._08_FacadePattern.Concrete;
using CS_ADVANCE.MichaelLam_Patterns._08_FacadePattern.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._08_FacadePattern
{
    public static class _08_FacadePattern
    {
        public static void Caller()
        {
            Dough dough = new Dough();
            Sauce sauce = new Sauce("Tomatoe");
            Topping mushroom = new Topping("Mushrooms");
            Cheese cheese = new Cheese("Mozzarella");
            Oven oven = new Oven();

            dough.AddSouce(sauce);
            dough.AddCheese(cheese);
            dough.AddTopping(mushroom);

            oven.SetTemp(425);
            oven.SetTimer(20);
            oven.Cook(dough);
        }

        public void Client1()
        {
            Dough dough = new Dough();
            Sauce sauce = new Sauce("Tomatoe");
            Topping mushroom = new Topping("Mushrooms");
            Cheese cheese = new Cheese("Mozzarella");

            //Lepiej zamiast przekazywać całe obiektt lepiej byłby tylko string
            PizzaFacade pf = new PizzaFacade(dough,sauce,mushroom,cheese);
            pf.MakePizza();
        }
    }
}
