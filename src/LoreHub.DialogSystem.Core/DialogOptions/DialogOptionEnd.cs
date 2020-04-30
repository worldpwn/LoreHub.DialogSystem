using System;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.Core.DialogOptions
{
    public class DialogOptionEnd<TContent> : IDialogOption<TContent> where TContent : IContent
    {
        public Guid Id { get; private set; }

        public TContent Content { get; private set; }

        public event EventHandler<DialogNode<TContent>> SelectEvent;

        public DialogOptionEnd(Guid id, TContent content)
        {
            if (content == null) throw new ArgumentNullException(nameof(content));

            this.Id = id;
            this.Content = content;
        }

        public void Select()
        {
            OnSelectEvent(EventArgs.Empty);
        }

        protected virtual void OnSelectEvent(EventArgs e)
        {
            EventHandler<DialogNode<TContent>> handler = SelectEvent;
            handler?.Invoke(this, null);
        }

    }
}
