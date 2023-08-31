using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Iterator
{
    public class ListAggregate<T> : IAggregate<T>
    {
        private List<T> collection;

        public T this[int index]
        {
            get { return collection[index]; }
            set { collection.Insert(index, value); }
        }
        public ListAggregate()
        {
            collection = new List<T>();
        }
        public Iterator<T> CreateIterator()
        {
            return new ListIterator<T>();
        }

        public void Insert(T item)
        {
            collection.Add(item);
        }

        public int Count()
        {
            return collection.Count;
        }



    }
}
