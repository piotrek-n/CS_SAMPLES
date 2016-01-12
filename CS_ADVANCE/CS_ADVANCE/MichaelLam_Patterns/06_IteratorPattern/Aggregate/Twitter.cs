using CS_ADVANCE.MichaelLam_Patterns._06_IteratorPattern.Iterator;
namespace CS_ADVANCE.MichaelLam_Patterns._06_IteratorPattern.Aggregate
{
    public class Twitter : ISocialNetworking
    {
        private string[] Users;

        public Twitter()
        {
            Users = new[] { "Kathy", "Lori", "Kristen", "Jamie" };
        }

        public Iterator.IIterator CreateIterator()
        {
            return new TwitterIterator(Users);
        }
    }
}