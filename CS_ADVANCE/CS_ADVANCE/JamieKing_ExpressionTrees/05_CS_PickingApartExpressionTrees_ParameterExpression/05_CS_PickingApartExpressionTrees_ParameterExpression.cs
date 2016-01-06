using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.Jamie_King_ExpressionTrees._05_CS_PickingApartExpressionTrees_ParameterExpression
{
    public static class _05_CS_PickingApartExpressionTrees_ParameterExpression
    {
        public static void Caller()
        {
            ConstantExpression constExp = Expression.Constant(5, typeof(int)); //Enum
            //Console.WriteLine(constExp.NodeType); //Constant
            //Console.WriteLine(constExp.Type);     //int32
            //Console.WriteLine(constExp.Value);    //5

            ParameterExpression iParam = Expression.Parameter(typeof(int), "i");
            Console.WriteLine(iParam.NodeType); //Paramter
            Console.WriteLine(iParam.Type); //Int32
            Console.WriteLine(iParam.Name); // "i" nie posiada za to Value
        }
    }
}
