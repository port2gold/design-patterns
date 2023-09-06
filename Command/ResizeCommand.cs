namespace design_patterns.Command
{
    internal class ResizeCommand : design_patterns.Command.fx.Command
    {
        public void Execute()
        {
            Console.WriteLine("Resize");
        }
    }
}
