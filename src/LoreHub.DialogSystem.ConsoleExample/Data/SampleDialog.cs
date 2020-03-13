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
                    new DialogOption(new Content(), null),
                    new DialogOption(new Content(), new DialogNode(new List<DialogOption>())),
                    new DialogOption(new Content(), null),
                });

            Dialog dialog = Dialog.CreateNew(startNode);

            return dialog;
        }
    }
}
