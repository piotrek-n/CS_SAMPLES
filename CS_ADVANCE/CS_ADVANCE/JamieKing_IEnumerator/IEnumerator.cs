﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.JamieKing_IEnumerator
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

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
    }
    public static class List
    {
        public static void ListCaller()
        {
            Console.WriteLine("List Caller");

            //Krok 1
            //List<int> myPartyAges2 = new List<int>();
            //myPartyAges2.Add(25);
            //myPartyAges2.Add(34);
            //myPartyAges2.Add(32);
            //myPartyAges2.Add(99);

            //myPartyAges2.Remove(2);

            //foreach (var i in myPartyAges2)
            //{
            //    Console.WriteLine(i);
            //}

            //Krok2

            MyList<int> myPartyAges2 = new MyList<int>();
            myPartyAges2.Add(25);
            myPartyAges2.Add(34);
            myPartyAges2.Add(32);
            myPartyAges2.Add(99);

            //myPartyAges2.Remove(2);

            foreach (var i in myPartyAges2)
            {
                Console.WriteLine(i);
            }

            //Petla foreach jest traktowana jako
            //IEnumerator<int> rator = myPartyAges2.GetEnumerator();
            //while (rator.MoveNext())
            //{
            //    Console.WriteLine(rator.Current);
            //}

        }
    }
}
