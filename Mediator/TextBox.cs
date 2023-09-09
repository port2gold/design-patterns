using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Mediator
{
    internal class TextBox : UIControl
    {
        private string content;

        public TextBox(DialogBox owner) : base(owner)
        {
        }

        public void SetContent(string content)
        {
            this.content = content;
            owner.Changed(this);
        }

        public string GetContent()
        {
            return this.content;
        }
    }
}
