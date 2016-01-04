using System;

namespace CS_ADVANCE.TUTS_Attributes
{
    public class AttributesCaller
    {
        public AttributesCaller()
        {
            //var types = from t in System.Reflection.Assembly.GetExecutingAssembly().GetType()
            //            where t.GetCustomAttributes<SampleAttribute>().Count() > 0
            //            select t;

            //foreach (var t in types)
            //{
            //    Console.WriteLine(t.Name);
            //    foreach (var p in t.GetProperties())
            //    {
            //        Console.WriteLine(p.Name);
            //    }
            //}
        }
    }

    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]
    [AttributeUsage(AttributeTargets.Class)]
    public class SampleAttribute : Attribute
    {
        public string Name { get; set; }

        public int Version { get; set; }
    }

    [Sample(Name="John",Version=1)]
    public class Test
    {
        //[Sample]
        public int IntValue { get; set; }

        //[Sample]
        public void Method()
        {
        }
    }

    public class NotAttribute
    {
    }
}