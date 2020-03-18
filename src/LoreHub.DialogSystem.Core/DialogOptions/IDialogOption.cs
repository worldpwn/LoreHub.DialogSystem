using System;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.Core.DialogOptions
{
    public interface IDialogOption<TContent> where TContent : IContent
    {
        TContent Content { get; }
        event EventHandler<DialogNode<TContent>> SelectEvent;
    }
}
