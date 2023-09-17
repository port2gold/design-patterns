namespace design_patterns.Decorator
{
    public class CompressCloudStream : Stream
    {
        private Stream stream;

        public CompressCloudStream(Stream stream)
        {
            this.stream = stream;
        }
        public void Write(string stream)
        {
            var compress = Compress(stream);
            this.stream.Write(compress);
        }

        private string Compress(string stream)
        {
            return stream.Substring(0, 5);
        }
    }
}
