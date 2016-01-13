using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._11_TemplateMethodPattern
{
    public class VeggiePizza: Pizza
    {


        //private void AddVeggieToppings()
        //{
        //    Console.WriteLine("AddVeggieToppings");
        //}

        private override void AddToppings()
        {
            Console.WriteLine("AddVeggieToppings");
        }

    }
}
