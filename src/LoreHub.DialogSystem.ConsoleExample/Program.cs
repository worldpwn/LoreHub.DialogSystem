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
                    new DialogOption("Option 2", new DialogNode(new List<DialogOption>())),
                    new DialogOption("Option 3", null),
                });

            Dialog dialog = Dialog.CreateNew(startNode);

            Console.WriteLine(dialog.CurrentNode.Content);


            Dictionary<string, Func<DialogNode>> actions = new Dictionary<string, Func<DialogNode>>();
            int optionNumber = 0;
            foreach (DialogOption option in dialog.CurrentNode.DialogOptions)
            {
                int currentOptionNumber = ++optionNumber;
                actions.Add(currentOptionNumber.ToString(), option.MoveNext);
                Console.WriteLine($"{currentOptionNumber} — {option.Content}");
            }
            
            string result =  Console.ReadLine();

            Console.WriteLine(actions[result].Invoke().Content);

        }
    }
}
