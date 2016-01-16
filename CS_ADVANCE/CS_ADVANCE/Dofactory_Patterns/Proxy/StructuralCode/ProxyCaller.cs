using System;
namespace CS_ADVANCE.Dofactory_Patterns.Proxy.StructuralCode
{
    public class ProxyCaller
    {
        public  static void Caller()
        {
            // Create proxy and request a service

            Proxy proxy = new Proxy();

            proxy.Request();



            // Wait for user

            Console.ReadKey();
        }
    }
}