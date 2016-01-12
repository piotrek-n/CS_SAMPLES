using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._06_IteratorPattern.Iterator
{
    public class FacebookIterator : IIterator
    {
        private LinkedList<string> Users;
        private int position = 0;
        public FacebookIterator(LinkedList<string> users)
        {
            this.Users = users;
            position = 0;
        }
        public void First()
        {
            position = 0;
        }

        public string Next()
        {
            return Users.ElementAt(position++);
        }

        public bool IsDone()
        {
            return position >= Users.Count;
        }

        public string CurrentItem()
        {
            return Users.ElementAt(position);
        }
    }
}
