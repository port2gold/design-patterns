

namespace design_patterns.AbstractFactory.Material
{
    public class MaterialWidgetFactory : WidgetFactory
    {
        public TextBox CreateTextBox()
        {
            return new MaterialTextBox();
        }

        Button WidgetFactory.CreateButton()
        {
            return new MaterialButton();
        }
    }
}
