using System;
namespace CS_ADVANCE.MichaelLam_Patterns._11_TemplateMethodPattern
{
    public abstract class Pizza
    {
        //TemplateMethod
        public void MakePizza()
        {
            MakeDough();
            AddTomatoeSauce();
            AddCheese();
            AddToppings();
        }

        public void AddCheese()
        {
            Console.WriteLine("AddCheese");
        }

        public void AddTomatoeSauce()
        {
            Console.WriteLine("AddTomatoeSauce");
        }

        public void MakeDough()
        {
            Console.WriteLine("MakeDough");
        }

        public abstract void AddToppings();

    }
}
