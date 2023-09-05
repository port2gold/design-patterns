namespace design_patterns.Template
{
    internal class TransferMoneyTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Transfer money");
        }
    }
}
