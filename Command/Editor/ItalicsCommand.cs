using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Command.Editor
{
    internal class ItalicsCommand : UndoableCommand
    {
        private string prevContent;
        private readonly HtmlDocument document;
        private readonly History history;

        public ItalicsCommand(HtmlDocument document, History history)
        {
            this.document = document;
            this.history = history;
        }
        
        public void Execute()
        {
            prevContent = document.GetContent();
            document.MakeItalics();
            history.Push(this);
        }

        public void Unexecute()
        {
            document.SetContent(prevContent);
        }
    }
}
