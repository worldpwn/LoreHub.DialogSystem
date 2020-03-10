using LoreHub.DialogSystem.ConsoleExample.Data;
using LoreHub.DialogSystem.ConsoleExample.Presentation;
using LoreHub.DialogSystem.Core;
using System;
using System.Collections.Generic;

namespace LoreHub.DialogSystem.ConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dialog dialog = SampleDialog.GetDialog();

            ConsoleDialog consoleDialog = new ConsoleDialog(dialog);
            consoleDialog.Start();


        }
    }
}
