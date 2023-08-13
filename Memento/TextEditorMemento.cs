using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Memento
{
    internal class TextEditorMemento : IMemento
    {
        private readonly string state;
        private readonly DateTimeOffset datecreated;
        public TextEditorMemento(string state)
        {
            this.state = state;
            this.datecreated = DateTimeOffset.Now;
                
        }
        public DateTimeOffset DateCreated()
        {
            return datecreated;
        }

        public string GetState()
        {
            return state;
        }
    }
}
