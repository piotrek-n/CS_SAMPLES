using CS_ADVANCE.MichaelLam_Patterns._06_IteratorPattern.Aggregate;
using CS_ADVANCE.MichaelLam_Patterns._06_IteratorPattern.Iterator;

namespace CS_ADVANCE.MichaelLam._06_IteratorPattern
{
    public static class _06_IteratorPattern
    {
        public static void Caller()
        {
            ISocialNetworking fb = new Facebook();
            ISocialNetworking tw = new Twitter();

            IIterator fbIterator = fb.CreateIterator();
            IIterator twIterator = tw.CreateIterator();

            System.Console.WriteLine("Facebook:");
            PrintUsers(fbIterator);
            System.Console.WriteLine("Twitter:");
            PrintUsers(twIterator);

        }

        public static void PrintUsers(IIterator iterator)
        {
            iterator.First();
            while (!iterator.IsDone())
            {
                System.Console.WriteLine(iterator.Next());
            }
        }
    }
}