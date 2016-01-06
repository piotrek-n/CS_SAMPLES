using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.Jamie_King_ExpressionTrees._02_ExpressionTrees
{
    public static class _02_ExpressionTrees
    {
        static bool djdasdas(int i)
        {
            return i > 5;
        }
        public static void _02_ExpressionTreesCaller()
        {     //01
              //Func<int, bool> test = djdasdas; // 1.  [CS file] ->CSC.EXE-> 2. [MSIL (.NET)] -> JIT -> 3. [NA (NativeAssembly)(CPU)]
              
              //02
              //Orginal Expression
              Expression<Func<int, bool>> exp = i => i > 5; //Traktowany jest jako zmienną
              Console.WriteLine(exp.Body.GetType()); //Body -> i => i > 5
              
              //What the compiler did:
              ParameterExpression expression3;
              Expression<Func<int, bool>> expression = Expression.Lambda<Func<int, bool>>(Expression.GreaterThan(expression3 = Expression.Parameter(typeof(int), "i"), Expression.Constant(5, typeof(int))), new ParameterExpression[] { expression3 });


              //BinaryExpression
              BinaryExpression binary = (BinaryExpression)exp.Body;
              Console.WriteLine(binary.Left);
              Console.WriteLine(binary.NodeType);
              Console.WriteLine(binary.Right);


            
        }
    }
}
