using System;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.Core
{
    public class DialogOption
    {
        public string Content { get; private set; }
        public DialogNode NextNode { get; private set; }

        public event EventHandler<DialogNode> SelectEvent;

        public DialogOption(string content, DialogNode nextNode)
        {
            Content = content;
            NextNode = nextNode;
        }

        public void Select()
        {
            OnSelectEvent(EventArgs.Empty);
        }

        protected virtual void OnSelectEvent(EventArgs e)
        {
            EventHandler<DialogNode> handler = SelectEvent;
            handler?.Invoke(this, NextNode);
        }

    }
}
