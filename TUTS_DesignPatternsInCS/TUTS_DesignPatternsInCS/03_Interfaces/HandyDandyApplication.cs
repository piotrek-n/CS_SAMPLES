using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTS_DesignPatternsInCS._03_Interfaces.Data.SqlServer;

namespace TUTS_DesignPatternsInCS._03_Interfaces
{
    public class HandyDandyApplication
    {
        private UserRepository _users;
        public HandyDandyApplication()
        {
            _users =new UserRepository();
        }

        public void DisplayUsers(TextWriter writer)
        {
            foreach (var user in _users.All())
            {
                var userData = string.Format("{0}\t{1} {2}",
                    user.Id,
                    user.FirstName,
                    user.LastName);
                writer.WriteLineAsync(userData);
            }
        }


    }
}
