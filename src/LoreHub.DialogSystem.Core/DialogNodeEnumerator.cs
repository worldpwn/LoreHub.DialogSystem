using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.Core
{
    public class DialogNodeEnumerator : IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public DialogNodeEnumerator(IEnumerable<DialogNode> dialogNodes)
        {

        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
