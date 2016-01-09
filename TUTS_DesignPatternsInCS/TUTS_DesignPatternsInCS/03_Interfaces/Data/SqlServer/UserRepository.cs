using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TUTS_DesignPatternsInCS._03_Interfaces.Data.SqlServer
{
    public class UserRepository : TUTS_DesignPatternsInCS._03_Interfaces.Data.SqlServer.IUserRepository
    {
        private static readonly List<User> _store;

        static UserRepository()
        {
            _store = new List<User>(new[]{
                new User { Id=1,FirstName="John", LastName= "Doe"},
                new User { Id=2,FirstName="James", LastName= "Doe"},
                new User { Id=3,FirstName="Jane", LastName= "Doe"},
                new User { Id=4,FirstName="Jennifer", LastName= "Doe"}
            });
        }

        public IEnumerable<User> All()
        {
            return _store;
        }

        public User GetBy(Expression<Func<User, bool>> expression)
        {
            IQueryable<User> users = _store.AsQueryable<User>().Where(expression);
            return users.FirstOrDefault();
        }

        public int Delete(Expression<Func<User, bool>> expression)
        {
            int result = 0;
            IQueryable<User> users = _store.AsQueryable<User>().Where(expression);
            foreach (var u in users)
            {
                _store.Remove(u);
                result = 1;
            }
            return result;
        }
    }
}