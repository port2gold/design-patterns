namespace design_patterns.Memento
{
    internal class CareTaker
    {
        private TextEditor textEditor;
        private Stack<IMemento> history;

        public CareTaker(TextEditor textEditor)
        {
            this.textEditor = textEditor;
            this.history = new Stack<IMemento>();
                
        }

        public void BackUp()
        {
            history.Push(textEditor.Save());
        }
        public void Revert() 
        {
            Console.WriteLine("Resotring a snapshot from history");

            if (history.Count == 0)
            {
                Console.WriteLine("No snapshot to restore");
                return;
            }
            textEditor.SetState(history.Pop());
        }
    }
}
