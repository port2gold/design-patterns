namespace design_patterns.Iterator
{
    public interface IAggregate<T>
    {
        Iterator<T> CreateIterator();

        void Insert(T item);

    }
}
