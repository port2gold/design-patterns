namespace design_patterns.Observer
{
    internal class SpreadSheet : Observer
    {
        private DataSource dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine($"Spread sheet was updated with value of {dataSource.GetValue()}"); ;
        }
    }
}
