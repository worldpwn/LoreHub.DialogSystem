using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.Core
{
    public class Dialog<TContent> where TContent : IContent
    {
        public DialogNode<TContent> CurrentNode { get; private set; }

        public IEnumerable<DialogNode<TContent>> DialogNodes => GetDialogNodes();

        private Dialog(DialogNode<TContent> startNode)
        {
            this.CurrentNode = startNode;
        }

        public static Dialog<TContent> CreateNew(DialogNode<TContent> startNode)
        {
            return new Dialog<TContent>(startNode);
        }

        private IEnumerable<DialogNode<TContent>> GetDialogNodes()
        {
            throw new NotImplementedException();
            // foreach (DialogNode node in CurrentNode)
            // {
            //     yield return node;
            // }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
