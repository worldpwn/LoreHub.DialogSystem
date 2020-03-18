using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LoreHub.DialogSystem.Core
{
    public class DialogNode<TContent> where TContent : IContent
    {
        public TContent Content { get; private set; }
        public IEnumerable<DialogOption<TContent>> DialogOptions { get; private set; }

        private DialogNode(IEnumerable<DialogOption<TContent>> dialogOptions)
        {
            this.DialogOptions = dialogOptions;
        }

        public static DialogNode<TContent> CreateNew(IEnumerable<DialogOption<TContent>> dialogOptions)
        {
            return new DialogNode<TContent>(dialogOptions);
        }
    }
}
