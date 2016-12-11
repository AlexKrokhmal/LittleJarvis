using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    public interface ICommand
    {
        bool CanExecute(string[] incomingCommandSplittedByWord);
        void DoSomething(string[] incomingCommandSplittedByWord);
    }
}
