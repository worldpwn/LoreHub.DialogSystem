using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LoreHub.DialogSystem.Core.DialogOptions;

namespace LoreHub.DialogSystem.Core
{
    public class DialogNode<TContent> where TContent : IContent
    {
        public TContent Content { get; private set; }
        public IEnumerable<IDialogOption<TContent>> DialogOptions { get; private set; }

        private DialogNode(TContent content, IEnumerable<IDialogOption<TContent>> dialogOptions)
        {
            this.Content = content;
            this.DialogOptions = dialogOptions;
        }

        public static DialogNode<TContent> CreateNew(TContent content, IEnumerable<IDialogOption<TContent>> dialogOptions)
        {
            return new DialogNode<TContent>(content, dialogOptions);
        }

        public static DialogNode<TContent> CreateExitNode(TContent content, IDialogOption<TContent> endOption)
        {
            return new DialogNode<TContent>(content, new List<IDialogOption<TContent>> { endOption });
        }
    }
}
