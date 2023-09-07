using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Command.Editor
{
    internal class History
    {
        private List<UndoableCommand> commands = new();

        public void Push(UndoableCommand command)
        {
            commands.Add(command);
        }

        public UndoableCommand Pop()
        {
            int last = commands.Count - 1;
            UndoableCommand command = commands[last];
            commands.RemoveAt(last);

            return command;
            
        }

        public int Size()
        {
            return commands.Count;
        }
    }
}
