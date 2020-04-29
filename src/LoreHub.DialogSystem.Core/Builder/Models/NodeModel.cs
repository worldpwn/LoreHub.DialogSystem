using System;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.Core.Builder.Models
{
    public class NodeModel<TContent> where TContent : IContent
    {
        public Guid Id { get; private set; }
        public TContent Content { get; private set; }
        public List<OptionModel<TContent>> Options { get; private set; }

        public NodeModel(Guid id, TContent content, List<OptionModel<TContent>> options)
        {
            Id = id;
            Content = content;
            Options = options;
        }
    }
}
