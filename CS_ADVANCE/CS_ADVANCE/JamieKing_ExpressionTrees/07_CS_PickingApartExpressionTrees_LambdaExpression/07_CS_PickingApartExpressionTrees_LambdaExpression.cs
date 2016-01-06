using System;
using System.Linq.Expressions;

namespace CS_ADVANCE.JamieKing_ExpressionTrees._07_CS_PickingApartExpressionTrees_LambdaExpression
{
    public static class _07_CS_PickingApartExpressionTrees_LambdaExpression
    {
        public static void Caller()
        {
            Expression<Func<int, bool>> exp = i => i > 5; //Traktowany jest jako zmienną

            ConstantExpression constExp = Expression.Constant(5, typeof(int)); //Enum

            ParameterExpression iParam = Expression.Parameter(typeof(int), "i");

            BinaryExpression greaterThan = Expression.GreaterThan(iParam, constExp);

            Expression<Func<int, bool>> test2
                = Expression.Lambda<Func<int, bool>>(greaterThan, iParam); // ====== exp

            Func<int, bool> myDele = exp.Compile();

            Console.WriteLine(myDele(3));
        }
    }
}