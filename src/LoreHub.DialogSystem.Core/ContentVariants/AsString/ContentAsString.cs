using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace LoreHub.DialogSystem.Core.ContentVariants.AsString
{
    [JsonConverter(typeof(ContentAsStringJsonConverter))]
    public class ContentAsString : IContent
    {
        public string Text { get; private set; }

        public ContentAsString(string text)
        {
            this.Text = text;
        }
    }
}
