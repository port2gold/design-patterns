namespace design_patterns.Proxy
{
    public class EbookProxy : IEbook
    {
        private string fileName;
        private Ebook ebook;

        public EbookProxy(string fileName)
        {
            this.fileName = fileName;
        }
        public string GetFileName()
        {
            return fileName;
        }

        public void Show()
        {
            if(ebook ==  null)
            {
                ebook = new Ebook(fileName);
            }
            ebook.Show();
        }
    }
}
