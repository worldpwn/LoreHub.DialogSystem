using LoreHub.DialogSystem.Core;
using System;

namespace LoreHub.DialogSystem.ConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DialogNode startNode = new DialogNode();

            Dialog dialog = Dialog.CreateNew(startNode);

            dialog.Start();
        }
    }
}
