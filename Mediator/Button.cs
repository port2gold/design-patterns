using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Mediator
{
    internal class Button : UIControl
    {
        private bool isEnabled;
        public Button(DialogBox owner) : base(owner)
        {
        }

        public void SetEnabled(bool enabled)
        {
            this.isEnabled = enabled;
            owner.Changed(this);
        }

        public bool IsEnabled()
        {
            return isEnabled;
        }
    }
}
