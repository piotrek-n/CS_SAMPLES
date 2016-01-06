using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_IEnumerableVsIEnumerator
{
    internal class MyList<T>: IEnumerable<T>
    {
        private T[] items = new T[5];

        private int count;

        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            items[count++] = item;
        }
        /// <summary>
        /// Użycie słowa kluczowego yield w celu zdefiniowania iteratora eliminuje konieczność jawnego użycia dodatkowej klasy
        /// (klasy przechowującej stan wyliczenia, na przykład IEnumerator<T>) podczas implementacji wzorców IEnumerable i IEnumerator dla niestandardowej kolekcji typów.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i]; //Bez yield pobierze całą kolekcję
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public static class List
    {
        public static void ListCaller()
        {
            Console.WriteLine("List Caller");

            //Generic
            //MyList<int> myPartyAges2 = new MyList<int>();
            //myPartyAges2.Add(25);
            //myPartyAges2.Add(34);
            //myPartyAges2.Add(32);


            //Zmiana polegająca na usuniecie metod Add, automatyczny podstawienie spowoduje zgłoszenie błedu braku IEnumerable
            MyList<int> myPartyAges2 = new MyList<int>() { 25, 34, 32 };
        }
    }
}
