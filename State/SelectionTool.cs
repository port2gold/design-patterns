namespace design_patterns.State
{
    public class SelectionTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Mouse Down on selection tool");
        }

        public void MouseUp()
        {
            Console.WriteLine("Mouse Up on selection tool");
        }
    }
}
