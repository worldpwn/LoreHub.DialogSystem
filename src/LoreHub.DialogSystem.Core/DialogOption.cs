using System;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.Core
{
    public class DialogOption
    {
        public string Content { get; private set; }
        public DialogNode NextNode { get; private set; }

        
        public DialogOption(string content, DialogNode nextNode)
        {
            Content = content;
            NextNode = nextNode;
        }

        public DialogNode MoveNext()
        {
            return NextNode;
        }

    }
}
