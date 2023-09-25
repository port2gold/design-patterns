

namespace design_patterns.AbstractFactory.Material
{
    public class MaterialTextBox : TextBox
    {
        void TextBox.Render()
        {
            Console.WriteLine("Material TextBox");
        }
    }
}
