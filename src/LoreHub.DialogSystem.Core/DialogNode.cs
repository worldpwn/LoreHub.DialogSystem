using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LoreHub.DialogSystem.Core
{
    public class DialogNode : IEnumerable
    {
        public Guid Id { get; private set; }
        public string Content => $"I am Node#{Id}";
        public IEnumerable<DialogOption> DialogOptions { get; private set; }

        private DialogNode _next;
        public DialogNode(IEnumerable<DialogOption> dialogOptions )
        {
            this.Id = Guid.NewGuid();
            this.DialogOptions = dialogOptions;
        }
        public IEnumerator GetEnumerator()
        {
            return new DialogNodeEnumerator(
                dialogNodes: DialogOptions.Select(o => o.NextNode));
        }
    }
}
