using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Command.Editor
{
    internal class BoldCommand : UndoableCommand
    {
        private string prevContent;
        private HtmlDocument document;
        private History history;

        public BoldCommand(HtmlDocument document, History history)
        {
            this.document = document;
            this.history = history;
        }
        public void Execute()
        {
            prevContent = document.GetContent();
            document.MakeBold();
            history.Push(this);
        }

        public void Unexecute()
        {
            document.SetContent(prevContent);
        }
    }
}
