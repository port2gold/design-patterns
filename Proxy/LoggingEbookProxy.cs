namespace design_patterns.Proxy
{
    public class LoggingEbookProxy : IEbook
    {
        private string fileName;
        private Ebook ebook;
        public LoggingEbookProxy(string fileName)
        {
            this.fileName = fileName;
        }
        public string GetFileName()
        {
            return fileName;
        }

        public void Show()
        {
            if(ebook == null)
            {
                ebook = new Ebook(fileName);
            }
            Console.WriteLine($"Logging Ebook {fileName}");
            ebook.Show();
        }
    }
}
