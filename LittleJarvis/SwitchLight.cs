using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    public class SwitchLight : Command
    {

        public SwitchLight()
        {
            name = "Turn off/on light";
            Example = "Turn on light in living room";
        }

        public override bool CanExecute(string[] incomingCommandSplittedByWord)
        {
            if ((incomingCommandSplittedByWord.Length >= 4)
                && (incomingCommandSplittedByWord[0].ToLower() == "turn")
                && ((incomingCommandSplittedByWord[1].ToLower() == "on") || ((incomingCommandSplittedByWord[1].ToLower() == "off")))
                && (incomingCommandSplittedByWord[2].ToLower() == "light")
                && (incomingCommandSplittedByWord[3].ToLower() == "in"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void DoSomething(string[] incomingCommandSplittedByWord)
        {
            if (incomingCommandSplittedByWord.Length > 4)
            {
                Console.Write("Ok, I will turn {0} light in", incomingCommandSplittedByWord[1]);
                for (int i = 4; i < incomingCommandSplittedByWord.Length; i++)
                {
                    Console.Write("{0} ", incomingCommandSplittedByWord[i]);
                }                
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("I cannot turn {0} lingt, because you did not mention the room or did it wrongly. Please, try again\n", incomingCommandSplittedByWord[1]);
            };
        }
    }
}
