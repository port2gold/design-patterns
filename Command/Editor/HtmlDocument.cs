namespace design_patterns.Command.Editor
{
    internal class HtmlDocument
    {
        private string content = string.Empty;
       
        public void MakeBold()
        {
            content = $"<b>{content}</b>";
        }

        public string GetContent()
        {
            return content ;
        }

        public void SetContent(string content)
        {
            this.content = content;
        }

        public void MakeItalics()
        {
            content = $"<i>{content}</i>";
        }
    }
}
