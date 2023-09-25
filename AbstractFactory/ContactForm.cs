namespace design_patterns.AbstractFactory
{
    public class ContactForm
    {
        public void Render(WidgetFactory factory)
        {
            factory.CreateTextBox().Render();
            factory.CreateButton().Render();
        }
    }
}
