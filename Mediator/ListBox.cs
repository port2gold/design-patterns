using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Mediator
{
    internal class ListBox : UIControl
    {
        private string selection;

        public ListBox(DialogBox owner) : base(owner)
        {
        }

        public string GetSelection()
        {
            return selection;
        }

        public void SetSelection(string selection)
        {
            this.selection = selection;
            owner.Changed(this);
        }
    }
}
