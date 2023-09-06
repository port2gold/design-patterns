using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Command
{
    internal class BlackAndWhiteCommand : design_patterns.Command.fx.Command
    {
        public void Execute()
        {
            Console.WriteLine("Black and White");
        }
    }
}
