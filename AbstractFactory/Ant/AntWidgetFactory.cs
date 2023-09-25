namespace design_patterns.AbstractFactory.Ant
{
    public class AntWidgetFactory : WidgetFactory
    {
        
        Button WidgetFactory.CreateButton()
        {
            return new AntButton();
        }

        TextBox WidgetFactory.CreateTextBox()
        {
            return new AntTextBox();
        }
    }
}
