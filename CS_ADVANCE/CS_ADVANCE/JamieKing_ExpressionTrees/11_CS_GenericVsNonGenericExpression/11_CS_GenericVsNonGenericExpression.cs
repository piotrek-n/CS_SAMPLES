using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_ExpressionTrees._11_CS_GenericVsNonGenericExpression
{
    public static class _11_CS_GenericVsNonGenericExpression
    {
        public static void Caller()
        {
            //Generic
            Expression<Func<int, bool>> exp = i => i > 5;
            //NonGeneric
            ConstantExpression constExp = Expression.Constant(5, typeof(int)); //Enum
        }
    }
}
