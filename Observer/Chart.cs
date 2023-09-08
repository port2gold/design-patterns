namespace design_patterns.Observer
{
    internal class Chart : Observer
    {
        private  DataSource dataSource;

        public Chart(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine($"Chart was updated with value of {dataSource.GetValue()}");
        }
    }
}
