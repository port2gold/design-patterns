namespace design_patterns.Observer
{
    internal class Chart : Observer
    {
        public void Update(int value)
        {
            Console.WriteLine($"Chart was updated with value of {value}");
        }
    }
}
