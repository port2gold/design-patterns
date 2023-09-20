namespace design_patterns.Proxy
{
    public class Ebook : IEbook
    {
        private string fileName;

        public Ebook(string fileName)
        {
            this.fileName = fileName;
            Load();
        }

        private void Load()
        {
            Console.WriteLine($"Loading the ebook {this.fileName}");
        }

        public void Show()
        {
            Console.WriteLine($"Showing the ebook {this.fileName}");
        }

        public string GetFileName()
        {
            return fileName;
        }
    }
}
