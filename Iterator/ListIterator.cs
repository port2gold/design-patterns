namespace design_patterns.Iterator
{
    public class ListIterator<T> : Iterator<T>
    {
        private ListAggregate<T> listAggregate;
        private int currentIndex;

        public ListIterator()
        {
            this.listAggregate = new ListAggregate<T>();
            currentIndex = 0;
        }
        public T Current()
        {
            return listAggregate[currentIndex];
        }

        public bool HasNext()
        {
            return currentIndex < listAggregate.Count();  
        }

        public void Next()
        {
            currentIndex++;
        }

        public void Add(T item)
        {
            listAggregate.Insert(item);
        }
    }
}
