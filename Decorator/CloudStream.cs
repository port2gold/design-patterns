namespace design_patterns.Decorator
{
    public class CloudStream : Stream
    {
        public void Write(string data)
        {
            Console.WriteLine($"Data: {data}");
        }

    }
}
