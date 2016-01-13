using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._11_TemplateMethodPattern
{
    class MeatLoverPizza : Pizza
    {


        private override void AddToppings()
        {
            Console.WriteLine("AddVeggieToppings");
        }
    }
}
