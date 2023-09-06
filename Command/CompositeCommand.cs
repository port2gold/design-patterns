namespace design_patterns.Command
{
    internal class CompositeCommand : fx.Command
    {
        private List<fx.Command> commands = new();

        public void AddCommand(fx.Command command)
        {
            commands.Add(command);
        }
        public void Execute()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
    }
}
