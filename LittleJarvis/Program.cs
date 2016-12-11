using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleJarvis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I'm Jarvis. I can help you with some tasks in daily life. \n*****Small hint: To get help you can type HELP and press the enter");

            string enteredCommand = null;

            bool doWeNeedToRepeat = true;

            bool wasTheCommandDone = false;

            var setOfSupportedCommands = new Command[3];
            var sendSms = new SendSms();
            setOfSupportedCommands[0] = sendSms;
            var sendEmail = new SendEmail();
            setOfSupportedCommands[1] = sendEmail;
            var switchLight = new SwitchLight();
            setOfSupportedCommands[2] = switchLight;


            do
            {
                wasTheCommandDone = false;

                enteredCommand = Console.ReadLine();

                string[] enteredCommandSeparatedByWhiteSpace = enteredCommand.Split();

                /*
                foreach (var item in enteredCommandSeparatedByWhiteSpace)
                {
                    Console.WriteLine(item);
                }                
                */

                Console.WriteLine("");

                if (enteredCommand.ToLower() == "help")
                {
                    Console.WriteLine("\n***********************************************************************************");
                    Console.WriteLine("Here is the list of supported commands:\n");
                    foreach (var item in setOfSupportedCommands)
                    {
                        Console.WriteLine(item.name);
                    }
                    Console.WriteLine("If you want to see examples, type EXAMPLES and press the enter");
                    Console.WriteLine("If you want to see the history of the commands, type HISTORY ans press the enter");
                    Console.WriteLine("\n***********************************************************************************");

                    continue;
                }
                

                if (enteredCommand.ToLower() == "examples")
                {
                    Console.WriteLine("\n***********************************************************************************");
                    Console.WriteLine("Here are the examples of supported commands usage:\n");
                    foreach (var item in setOfSupportedCommands)
                    {
                        Console.WriteLine("Command name {0}:\n{1}\n", item.name, item.Example);
                    }
                    Console.WriteLine("\n***********************************************************************************");

                    continue;
                }               


                foreach (var item in setOfSupportedCommands)
                {                    
                    if (item.CanExecute(enteredCommandSeparatedByWhiteSpace))
                    {                        
                        item.DoSomething(enteredCommandSeparatedByWhiteSpace);
                        wasTheCommandDone = true;
                        break;
                    }                    
                }

                //Console.WriteLine("Was the command executed - {0}", wasTheCommandDone);

                if (!wasTheCommandDone)
                {
                    Console.WriteLine("\n-----------------------------------------------------------------------------------");
                    Console.WriteLine("I'm just a 'little' Jarvis, I don't know such a command.\nTo get help you can type HELP and press the enter");
                    Console.WriteLine("-----------------------------------------------------------------------------------\n");                    
                }


            } while (doWeNeedToRepeat);



            Console.ReadLine();
        }
    }
}
