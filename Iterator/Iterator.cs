namespace design_patterns.Iterator
{
    public interface Iterator<T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}
