namespace design_patterns.Observer
{
    internal class SpreadSheet : Observer
    {
        public void Update(int value)
        {
            Console.WriteLine($"Spread sheet was updated with value of {value}"); ;
        }
    }
}
