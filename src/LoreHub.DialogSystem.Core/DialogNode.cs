using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LoreHub.DialogSystem.Core
{
    public class DialogNode : IEnumerable
    {
        private DialogNode _next;

        public IEnumerable<DialogOption> DialogOptions { get; private set; }

        public IEnumerator GetEnumerator()
        {
            return new DialogNodeEnumerator(
                dialogNodes: DialogOptions.Select(o => o.NextNode));
        }
    }
}
