using System;
namespace CS_ADVANCE.MichaelLam_Patterns._11_TemplateMethodPattern
{
    public static class _11_TemplateMethodPattern
    {
        public static void Caller()
        {
            Pizza mlp = new MeatLoverPizza();
            mlp.MakePizza();

            Pizza vp = new VeggiePizza();
            vp.MakePizza();

            Console.ReadKey();
        }
    }
}