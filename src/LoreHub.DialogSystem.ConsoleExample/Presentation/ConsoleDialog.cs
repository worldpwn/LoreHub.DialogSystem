using LoreHub.DialogSystem.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.ConsoleExample.Presentation
{
    public class ConsoleDialog
    {
        public Dialog Dialog { get; private set; }

        public ConsoleDialog(Dialog dialog)
        {
            Dialog = dialog ?? throw new ArgumentNullException(nameof(dialog));
        }

        public void Start()
        {
            Console.WriteLine("Starting dialog...");

            ConsoleDialogNode dialogNode = new ConsoleDialogNode(this.Dialog.CurrentNode);
            dialogNode.Show();
        }
    }
}
