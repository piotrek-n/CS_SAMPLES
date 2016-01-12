using CS_ADVANCE.MichaelLam_Patterns._06_IteratorPattern.Iterator;
using System.Collections.Generic;

namespace CS_ADVANCE.MichaelLam_Patterns._06_IteratorPattern.Aggregate
{
    public class Facebook : ISocialNetworking
    {
        private LinkedList<string> Users;

        public Facebook()
        {
            Users = new LinkedList<string>();

            Users.AddLast("Mike");
            Users.AddLast("Jakson");
            Users.AddLast("Asad");
            Users.AddLast("Sen");
            Users.AddLast("Vish");
            Users.AddLast("Senthu");
        }

        public Iterator.IIterator CreateIterator()
        {
            return new FacebookIterator(Users);
        }
    }
}