using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace TUTS_DesignPatternsInCS._03_Interfaces.Data.SqlServer
{
    interface IUserRepository
    {
        IEnumerable<User> All();
        int Delete(Expression<Func<User, bool>> expression);
        User GetBy(Expression<Func<User, bool>> expression);
    }
}
