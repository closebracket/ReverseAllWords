using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAllWords.Helpers
{
    internal class TerminalControls
    {
        public static void terminalEventHandler(object sender, ConsoleCancelEventArgs args)
        {
            args.Cancel = true;
        }
    }
}
