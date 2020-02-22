using LoreHub.DialogSystem.Core;
using System;
using System.Collections.Generic;

namespace LoreHub.DialogSystem.ConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DialogNode startNode = new DialogNode(new List<DialogOption> 
                {
                    new DialogOption("Option 1", null),
                    new DialogOption("Option 2", null),
                    new DialogOption("Option 3", null),
                });

            Dialog dialog = Dialog.CreateNew(startNode);

            Console.WriteLine(dialog.CurrentNode.Content);

            foreach (DialogOption option in dialog.CurrentNode.DialogOptions)
            {
                Console.WriteLine(option.Content);
            }
            
            Console.ReadLine();

        }
    }
}
