namespace design_patterns.Mediator
{
    internal class Button : UIControl
    {
        private bool isEnabled;
        //public Button(DialogBox owner) : base(owner)
        //{
        //}

        public void SetEnabled(bool enabled)
        {
            this.isEnabled = enabled;
            NotifyEventHandlers();
        }

        public bool IsEnabled()
        {
            return isEnabled;
        }
    }
}
