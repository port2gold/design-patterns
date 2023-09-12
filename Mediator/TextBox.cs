namespace design_patterns.Mediator
{
    internal class TextBox : UIControl
    {
        private string content;

        //public TextBox(DialogBox owner) : base(owner)
        //{
        //}
        public event Action TitleChangedEvent;


        public void SetContent(string content)
        {
            this.content = content;
            NotifyEventHandlers();
        }

        public string GetContent()
        {
            return this.content;
        }

        protected void OnTitleChanged()
        {
            TitleChangedEvent?.Invoke();
        }
    }
}
