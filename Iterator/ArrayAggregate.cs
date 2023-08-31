using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Iterator
{
    internal class ArrayAggregate<T> : IAggregate<T>
    {
        private T[] collection;
        public ArrayAggregate()
        {
                collection = new T[10];
        }

        public T this[int index]
        {
            get { return collection[index]; }
            set { collection[index] = value; }
        }
        public Iterator<T> CreateIterator()
        {
            return new ArrayIterator<T>();
        }

        public void Insert(T item)
        {
            int index = collection.Length;
            collection[index] = item;
        }

        public int Count()
        {
            return collection.Length;
        }
    }
}
