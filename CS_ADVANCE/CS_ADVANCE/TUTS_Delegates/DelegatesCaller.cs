using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.TUTS_Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegateWithName(string name);

   public delegate void Operation(int number);  

    public static class DelegatesCaller
    {
        public static MyDelegate myDeleg = new MyDelegate(MyMethod); //public static MyDelegate myDeleg = MyMethod;
        public static void MyMethod()
        {
            Console.WriteLine("Hi that is delegate");
        }
        public static void MyMethodWithName(string name)
        {
            Console.WriteLine("Hi that is delegate");
        }

        public static void CallerMyMethod()
        {
            myDeleg.Invoke(); //myDeleg() 
            Test(myDeleg);

            Operation op = Double;
            ExecuteOperation(2, op);

            op = Triple;
            ExecuteOperation(2, op);

            op -= Triple;
            op += Double;
            op += Triple;

            ExecuteOperation(2, op);
        } 

        private static void Triple(int num)
        {
            Console.WriteLine("{0} x 3 ={1}", num, num * 3);
        }

        public static void Test(MyDelegate deleg)
        {
            deleg();
        }

        public static MyDelegateWithName GiveMeMyDelegateWithName()
        {
            return new MyDelegateWithName(MyMethodWithName); 
        }

        public static void Double(int num)
        {
            Console.WriteLine("{0} x 2 ={1}", num, num * 2);
        }
        static void ExecuteOperation(int num, Operation operation)
        {
            operation(num);
        }
    }
}
