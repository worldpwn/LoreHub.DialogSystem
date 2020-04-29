using System;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.Core.Builder.Models
{
    public class OptionModel<TContent> where TContent : IContent
    {
        public Guid Id { get; private set; }
        public TContent Content { get; private set; }
        public Guid NextNodeId { get; private set; }

        public OptionModel(Guid id, TContent content, Guid nextNodeId)
        {
            Id = id;
            Content = content;
            NextNodeId = nextNodeId;
        }
    }
}
