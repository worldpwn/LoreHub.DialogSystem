using System;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.Core
{
    public class DialogOption<TContent> where TContent : IContent
    {
        public TContent Content { get; private set; }
        public DialogNode<TContent> NextNode { get; private set; }

        public event EventHandler<DialogNode<TContent>> SelectEvent;

        public DialogOption(TContent content, DialogNode<TContent> nextNode)
        {
            if (content == null) throw new ArgumentNullException(nameof(content));
            Content = content  ;
            NextNode = nextNode ?? throw new ArgumentNullException(nameof(content));
        }

        public void Select()
        {
            OnSelectEvent(EventArgs.Empty);
        }

        protected virtual void OnSelectEvent(EventArgs e)
        {
            EventHandler<DialogNode<TContent>> handler = SelectEvent;
            handler?.Invoke(this, NextNode);
        }

    }
}
