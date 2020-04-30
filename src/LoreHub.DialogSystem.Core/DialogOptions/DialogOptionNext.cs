using System;

namespace LoreHub.DialogSystem.Core.DialogOptions
{
    public class DialogOptionNext<TContent> : IDialogOption<TContent> where TContent : IContent
    {
        public Guid Id { get; private set; }
        public TContent Content { get; private set; }
        public DialogNode<TContent> NextNode { get; private set; }
        public event EventHandler<DialogNode<TContent>> SelectEvent;
        public DialogOptionNext(Guid id, TContent content, DialogNode<TContent> nextNode)
        {
            if (content == null) throw new ArgumentNullException(nameof(content));
            if (nextNode == null) throw new ArgumentNullException(nameof(nextNode));

            this.Id = id;
            this.Content = content;
            this.NextNode = nextNode;
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
