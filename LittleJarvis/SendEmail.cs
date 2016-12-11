using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    public class SendEmail : Command
    {
        public SendEmail()
        {
            name = "Send email";
            Example = "Send email to NAME : email body";
        }

        public override bool CanExecute(string[] incomingCommandSplittedByWord)
        {
            if ((incomingCommandSplittedByWord.Length >= 3)
                && (incomingCommandSplittedByWord[0].ToLower() == "send")
                && (incomingCommandSplittedByWord[1].ToLower() == "email")
                && (incomingCommandSplittedByWord[2].ToLower() == "to"))
            {
                Console.WriteLine("email can execute");
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void DoSomething(string[] incomingCommandSplittedByWord)
        {
            collonIndex = -1;
            if (GetColonIndex(incomingCommandSplittedByWord) != -1)
            {
                Console.Write("Ok, I will send email with text '");
                for (int i = collonIndex + 1; i < incomingCommandSplittedByWord.Length; i++)
                {
                    Console.Write("{0} ", incomingCommandSplittedByWord[i]);
                }
                Console.Write("' to");
                for (int i = 3; i < collonIndex; i++)
                {
                    Console.Write(" {0}", incomingCommandSplittedByWord[i]);
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("I cannot send this email due to wrong formal or missing address/text/:. Please, try again\n");
            }
        }

    }
}
