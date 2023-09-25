using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.AbstractFactory
{
    public interface WidgetFactory
    {
        Button CreateButton();
        TextBox CreateTextBox();

    }
}
