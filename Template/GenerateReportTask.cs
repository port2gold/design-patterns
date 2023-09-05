namespace design_patterns.Template
{
    internal class GenerateReportTask : Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Generate Report");
        }
    }
}
