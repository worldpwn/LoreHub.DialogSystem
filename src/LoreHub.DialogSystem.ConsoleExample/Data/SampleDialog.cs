using LoreHub.DialogSystem.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.ConsoleExample.Data
{
    public class SampleDialog
    {
        public static Dialog GetDialog()
        {
            DialogNode startNode = new DialogNode(new List<DialogOption>
                {
                    new DialogOption("Option 1", null),
                    new DialogOption("Option 2", new DialogNode(new List<DialogOption>())),
                    new DialogOption("Option 3", null),
                });

            Dialog dialog = Dialog.CreateNew(startNode);

            return dialog;
        }
    }
}
