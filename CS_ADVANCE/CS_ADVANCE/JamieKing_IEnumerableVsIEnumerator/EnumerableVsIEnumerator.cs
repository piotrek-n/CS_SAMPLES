using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_IEnumerableVsIEnumerator
{
    internal class MyList<T>
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
            //for (int i = 0; i < count; i++)
            //{
            //yield return items[i]; //Bez yield pobierze całą kolekcję
            //}

            //Pętla for została zastąpiona, tak jak poniżej
            return new MyEnumerator(this);
        }
        //Rozwiązanie z klasą implem. IEnumerator jest nierekomendowane. 
        class MyEnumerator : IEnumerator<T>
        {
            int index = -1;
            MyList<T> _theList;

            public MyEnumerator(MyList<T> theList)
            {
                this._theList = theList;
            }
            public bool MoveNext()
            {
                return ++index < _theList.count;
            }
            public T Current
            {
                get
                {
                    if (index < 0 || _theList.count <= index)
                        return default(T);
                    return _theList.items[index];
                }
            }

            public void Dispose()
            {
                Console.WriteLine("I am disposing of myself");
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }

    public static class List
    {
        public static void ListCaller()
        {
            Console.WriteLine("List Caller");

            //Generic
            MyList<int> myPartyAges2 = new MyList<int>();
            myPartyAges2.Add(25);
            myPartyAges2.Add(34);
            myPartyAges2.Add(32);

            IEnumerator rator = myPartyAges2.GetEnumerator();
            //Console.WriteLine(rator.Current);//Wartość 0, wartość z dupy!!!!
            rator.MoveNext();
            rator.MoveNext();
            rator.MoveNext();
            rator.MoveNext();


            //NonGeneric
            ArrayList myPartyAges1 = new ArrayList();
            myPartyAges1.Add(25);
            myPartyAges1.Add(34);
            myPartyAges1.Add(32);

            IEnumerator rator1 = myPartyAges1.GetEnumerator();
            //Console.WriteLine(rator.Current);//Error!!! Jesteś poza
            rator1.MoveNext();
            rator1.MoveNext();
            rator1.MoveNext();
            rator1.MoveNext();
            //Console.WriteLine(rator.Current);//Error!!! Jesteś poza


            //Generic
            MyList<int> myPartyAges3 = new MyList<int>();
            myPartyAges3.Add(25);
            myPartyAges3.Add(34);
            myPartyAges3.Add(32);
            foreach (var i in myPartyAges3)
            {
                Console.WriteLine(i);
            }

            //IEnumerator<int> rator2 = myPartyAges3.GetEnumerator();
            //try
            //{
            //    while (rator2.MoveNext())
            //    {
            //        Console.WriteLine(rator.Current);
            //    }
            //}
            //finally
            //{
            //    //rator.Dispose();
            //}
        }
    }
}
