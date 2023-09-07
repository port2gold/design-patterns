using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Command.Editor
{
    internal interface UndoableCommand : Command
    {
        void Unexecute();
    }
}
