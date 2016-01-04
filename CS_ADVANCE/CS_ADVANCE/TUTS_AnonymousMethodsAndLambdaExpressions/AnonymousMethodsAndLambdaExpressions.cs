using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.TUTS_AnonymousMethodsAndLambdaExpressions
{
    delegate int Operation(int number);

    public static class AnonymousMethodsAndLambdaExpressions
    {
        public static   void CallerAnonymousMethodsAndLambdaExpressions()
        {
            //Anonymous
            Operation op = Double;
            op(2); 
            op -= Double;
            op = delegate(int num) { Console.WriteLine("{0}  x2 = {1} " , num, num * 2); return 0; };
            var val =  op(3);

            //Lambda

            op = null;
            op = (num) => { Console.WriteLine("{0}  x4 = {1} ", num, num * 4); return 0; };
            val = op(4);

            //Generic
            Action<int> op_a = (num) => { Console.WriteLine("{0}  x4 = {1} ", num, num * 4); };
            Func<int, int> op_f = (num) => { Console.WriteLine("{0}  x4 = {1} ", num, num * 4); return 0; };
            Console.WriteLine(op_f(2));
        } 

        static int Double(int num)
        {
            Console.WriteLine("{0}  x2 = {1} ", num, num*2);
            return 0;
        }
    }
}
