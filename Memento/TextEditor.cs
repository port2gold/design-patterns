namespace design_patterns.Memento
{
    internal class TextEditor
    {
        private string state;
        public TextEditor()
        {
               this.state = string.Empty; 
        }
        public string GetCurrentText()
        {
            return state;
        }

        public void UpdateText(string updatedText)
        {
            state = updatedText;
        }

        public IMemento Save()
        {
            Console.WriteLine("Saving state...");
            return new TextEditorMemento(state);
        }

        public void SetState(IMemento memento)
        {
            state = memento.GetState();
            Console.WriteLine($"Restore state from snapshot created at {memento.DateCreated()}");
        }
    }
}
