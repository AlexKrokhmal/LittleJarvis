using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    public abstract class Command : ICommand
    {
        public string name;
        protected int collonIndex = -1;

        public string Example;

        public abstract bool CanExecute(string[] incomingCommandSplittedByWord);
        
        public abstract void DoSomething(string[] incomingCommandSplittedByWord);

        protected int GetColonIndex(string[] incommingCommandSplittedByWord)
        {
            for (int i = 4; i < incommingCommandSplittedByWord.Length; i++)
            {
                if (incommingCommandSplittedByWord[i].ToString() == ":" && i < (incommingCommandSplittedByWord.Length - 1))
                {
                    collonIndex = i;                    
                    break;
                }
                else
                {
                    collonIndex = -1;
                }
            }
            return collonIndex;
        }

        
    }
}
