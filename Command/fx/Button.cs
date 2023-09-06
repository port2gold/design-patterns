namespace design_patterns.Command.fx
{
    internal class Button
    {
        private  Command command;
        private string label;

        public Button(Command command)
        {
            this.command = command;
        }

        public void Click()
        {
            command.Execute(); 
        }

        public string GetLabel()
        { 
            return label;
        }

        public void SetLabel(string label)
        {
            this.label = label;
        }
    }
}
