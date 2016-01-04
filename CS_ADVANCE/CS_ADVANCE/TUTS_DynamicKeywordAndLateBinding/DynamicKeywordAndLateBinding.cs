using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.DynamicKeywordAndLateBinding
{
    public static class DynamicKeywordAndLateBinding
    {
        public static void DynamicKeywordAndLateBindingCaller()
        {
            var t = "string";

            dynamic test = "string";
            test = 5;

            //Shift + Alt + F10
            var pythonRuntime = IronPython.Hosting.Python.CreateRuntime();
            dynamic pythonFile = pythonRuntime.UseFile("Test.py");
            pythonFile.SayHellToPython();

            //ExpandoObject
            dynamic test2 = new ExpandoObject();

            test2.Name = "John";
            test2.Age = 35;

            Console.WriteLine(test2.Name);
            Console.WriteLine(test2.Age);

        }
    }
}
