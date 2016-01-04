using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE
{
    public class List
    {
        public void Add(int number)
        {
            throw new NotImplementedException();
        }

        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class BookList
    {
        public void Add(Book number)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    //Problem z wydajność
    public class ObjectList
    {
        public void Add(object number)
        {
            throw new NotImplementedException();
        }

        public object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericList<T>
    {
        public void Add(T value)
        { 
        
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }

}
