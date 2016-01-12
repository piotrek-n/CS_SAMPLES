using CS_ADVANCE.MichaelLam_Patterns._08_FacadePattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._08_FacadePattern.Facade
{
    public class PizzaFacade
    {
        Dough dough;
        Sauce sauce; 
        Topping mushroom;
        Cheese cheese;
        Oven oven;
        public PizzaFacade(Dough dough,Sauce sauce,Topping mushroom,Cheese cheese)
        {
            this.dough = dough;
            this.sauce = sauce;
            this.mushroom = mushroom;
            this.cheese = cheese;
            this.oven = new Oven();
        }
        public void MakePizza()
        {
            this.dough.AddSouce(this.sauce);
            this.dough.AddCheese(this.cheese);
            this.dough.AddTopping(this.mushroom);

            this.oven.SetTemp(425);
            this.oven.SetTimer(20);
            this.oven.Cook(this.dough);
        }
    }
}
