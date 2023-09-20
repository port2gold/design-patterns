namespace design_patterns.Proxy
{
    public class Library
    {
        private Dictionary<string, IEbook> ebooks = new Dictionary<string, IEbook>(); 
        public void Add(IEbook ebook)
        {
            ebooks.Add(ebook.GetFileName(), ebook);
        }

        public void OpenEbook(string filename)
        {
            if(ebooks.ContainsKey(filename))
            {
                ebooks[filename].Show();
            }
        }
    }
}
