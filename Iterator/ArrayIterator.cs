using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Iterator
{
    internal class ArrayIterator<T> : Iterator<T>
    {
        private int currentIndex;
        private ArrayAggregate<T> aggregate;
        public ArrayIterator()
        {
            aggregate = new ArrayAggregate<T>();
            currentIndex = 0;
        }
        public T Current()
        {
            return aggregate[currentIndex];
        }

        public bool HasNext()
        {
            return currentIndex < aggregate.Count();
        }

        public void Next()
        {
            currentIndex++;
        }
    }
}
