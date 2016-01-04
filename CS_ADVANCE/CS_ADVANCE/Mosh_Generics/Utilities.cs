using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE
{
    //where T: IComparable
    //where T: Product
    //where T: struct
    //where T: class
    //where T: new()
    public class Utilitie<T> where T: IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        public void DoSomething(T value)
        {
            var obj = new T();
        }
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    public class Nullable<T> where T:struct
    {
        private object _value;
        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        { 
            get { return _value != null ;}
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
}
