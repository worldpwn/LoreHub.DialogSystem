using System;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.Core
{
    public class Dialog
    {
        public DialogNode CurrentNode { get; private set; }

        public IEnumerable<DialogNode> DialogNodes => GetDialogNodes();

        private Dialog(DialogNode startNode)
        {
            CurrentNode = startNode;
        }

        public static Dialog CreateNew(DialogNode startNode)
        {
            return new Dialog(startNode);
        }

        public void Start()
        {

        }

        private IEnumerable<DialogNode> GetDialogNodes()
        {
            foreach (DialogNode node in CurrentNode)
            {
                yield return node;
            }
        }
    }
}
