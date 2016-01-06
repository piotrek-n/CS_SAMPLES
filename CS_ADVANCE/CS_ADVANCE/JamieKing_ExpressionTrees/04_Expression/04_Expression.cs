using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.Jamie_King_ExpressionTrees._04_Expression
{
    public static class _04_Expression
    {
        public static void Caller()
        {
            ConstantExpression constExp = Expression.Constant(5, typeof(int)); //Enum
            Console.WriteLine(constExp.NodeType); //Constant
            Console.WriteLine(constExp.Type);     //int32
            Console.WriteLine(constExp.Value);    //5
        }

    }
}
