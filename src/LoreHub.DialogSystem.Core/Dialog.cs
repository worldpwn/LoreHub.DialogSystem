using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.Core
{
    public class Dialog<TContent> where TContent : IContent
    {
        public DialogNode<TContent> CurrentNode { get; private set; }

        private Dialog(DialogNode<TContent> startNode)
        {
            this.CurrentNode = startNode;
            this.SubscribeToCurrentNodeEvent();
        }

        public static Dialog<TContent> CreateNew(DialogNode<TContent> startNode)
        {
            return new Dialog<TContent>(startNode);
        }

        private void SubscribeToCurrentNodeEvent()
        {
            this.CurrentNode.ChangeNodeEvent += ChangeNodeEvent;
        }

        private void ChangeNodeEvent(object sender, DialogNode<TContent> nextNode)
        {
            this.CurrentNode = nextNode;
            this.SubscribeToCurrentNodeEvent();
        }
    }
}
