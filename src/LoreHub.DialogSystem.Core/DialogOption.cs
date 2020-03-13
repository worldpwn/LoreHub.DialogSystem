using System;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.Core
{
    public class DialogOption
    {
        public Content Content { get; private set; }
        public DialogNode NextNode { get; private set; }

        public event EventHandler<DialogNode> SelectEvent;

        public DialogOption(Content content, DialogNode nextNode)
        {
            Content = content ?? throw new ArgumentNullException(nameof(content));
            NextNode = nextNode ?? throw new ArgumentNullException(nameof(content));
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
