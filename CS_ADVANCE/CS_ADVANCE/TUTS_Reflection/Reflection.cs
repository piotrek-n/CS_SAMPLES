using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.TUTS_Reflection
{
    public static class ReflectionCaller
    {
        public static void ReflectionCallerTest()
        {
            Assembly varAssembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(varAssembly.FullName);

            //foreach (var type in varAssembly.GetTypes())
            //{
            //    Console.WriteLine("Type:" + type.Name);
            //    var props = type.GetProperties();
            //    foreach (var p in props)
            //    {
            //        Console.WriteLine("\t Propery" + p.Name + "ProperyType: " + p.PropertyType);
            //    }
            //    var fields = type.GetFields();
            //    foreach (var f in fields)
            //    {
            //        Console.WriteLine("\t Field" + f.Name);
            //    }

            //    var methods = type.GetMethods();
            //    foreach (var m in methods)
            //    {
            //        Console.WriteLine("\t Method" +  m.Name);
            //    }
                
            //}

            //var sampleRefClass = new SampleReflectClass() { Name = "Jan", Age = 25 };
            //var sampleType = typeof(SampleReflectClass);

            //var myMethod = sampleType.GetMethod("MyMethod");
            //myMethod.Invoke(sampleRefClass, null);

            var types = varAssembly.GetTypes().Where(
                                                        t => t.GetCustomAttributes(typeof(MyAttributeClass), true).Length > 0
                                                    );
        }

        

    }
    [MyAttributeClass]
    public class SampleReflectClass
    {
        public string Name { get; set; }
        public int Age { get; set; }

        [MyAttributeMethod]
        public void MyMethod()
        {
            Console.WriteLine("Hi from MyMethod");
        }

    }

    [AttributeUsage(AttributeTargets.Class)]
    public class MyAttributeClass : Attribute
    {
    }
    [AttributeUsage(AttributeTargets.Method)]
    public class MyAttributeMethod : Attribute
    {
    }
}