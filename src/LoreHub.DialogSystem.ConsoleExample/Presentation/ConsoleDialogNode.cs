using LoreHub.DialogSystem.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoreHub.DialogSystem.ConsoleExample.Presentation
{
    public class ConsoleDialogNode
    {
        public string Content { get; private set; }

        public Dictionary<string, DialogOption> Options { get; private set; }

        public ConsoleDialogNode(DialogNode dialogNode)
        {
            if (dialogNode is null) throw new ArgumentNullException(nameof(dialogNode));
            Content = dialogNode.Content;
            Options = CreateDialogOptions(dialogNode);
        }

        public void Show()
        {
            DisplyContent();
            DisplyOptions();
        }

        private void DisplyContent()
        {
            Console.WriteLine(this.Content);
        }

        private void DisplyOptions()
        {
            foreach (KeyValuePair<string, DialogOption> option in Options)
            {
                Console.WriteLine($"{option.Key} — {option.Value.Content}");
            }
        }

        private Dictionary<string, DialogOption> CreateDialogOptions(DialogNode dialogNode)
        {
            Dictionary<string, DialogOption> options = new Dictionary<string, DialogOption>();
            int optionNumber = 0;
            foreach (DialogOption option in dialogNode.DialogOptions)
            {
                int currentOptionNumber = ++optionNumber;
                options.Add(currentOptionNumber.ToString(), option);
            }

            return options;
        }
    }
}
