using System;
using System.Linq.Expressions;

namespace CS_ADVANCE.Jamie_King_ExpressionTrees.PickingApartExpressionTrees__ConstExpression
{
    public static class _03_PickingApartExpressionTrees__ConstExpression
    {
        public static void Caller()
        {
            ////01
            ////Func<int, bool> test = djdasdas; // 1.  [CS file] ->CSC.EXE-> 2. [MSIL (.NET)] -> JIT -> 3. [NA (NativeAssembly)(CPU)]

            ////02
            ////Orginal Expression
            //Expression<Func<int, bool>> exp = i => i > 5; //Traktowany jest jako zmienną
            //Console.WriteLine(exp.Body.GetType()); //Body -> i => i > 5

            ////What the compiler did:
            //ParameterExpression expression3;
            //Expression<Func<int, bool>> expression = Expression.Lambda<Func<int, bool>>(Expression.GreaterThan(expression3 = Expression.Parameter(typeof(int), "i"), Expression.Constant(5, typeof(int))), new ParameterExpression[] { expression3 });

            ////BinaryExpression
            //BinaryExpression binary = (BinaryExpression)exp.Body;
            //Console.WriteLine(binary.Left);
            //Console.WriteLine(binary.NodeType);
            //Console.WriteLine(binary.Right);

            //03
            ConstantExpression constExp = Expression.Constant(5, typeof(int)); //Enum
            Console.WriteLine(constExp.NodeType); //Constant
            Console.WriteLine(constExp.Type);     //int32
            Console.WriteLine(constExp.Value);    //5
        }
    }
}