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

        private DialogNode(IEnumerable<IDialogOption<TContent>> dialogOptions)
        {
            this.DialogOptions = dialogOptions;
        }

        public static DialogNode<TContent> CreateNew(IEnumerable<IDialogOption<TContent>> dialogOptions)
        {
            return new DialogNode<TContent>(dialogOptions);
        }

        public static DialogNode<TContent> CreateExitNode(IDialogOption<TContent> exitOption)
        {
            return new DialogNode<TContent>(new List<IDialogOption<TContent>> { exitOption });
        }
    }
}
