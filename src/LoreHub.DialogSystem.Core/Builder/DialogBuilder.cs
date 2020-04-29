using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using LoreHub.DialogSystem.Core.Builder.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LoreHub.DialogSystem.Core.Builder
{
    public class DialogBuilder<TContent> where TContent : IContent
    {
        //private readonly JsonConverter _contentJsonConverter;
        //public DialogBuilder(JsonConverter contentJsonConverter)
        //{
        //    this._contentJsonConverter = contentJsonConverter;
        //}

        public Dialog<TContent> CreateFromJSON(string path)
        {
            JArray jsonArray;
            using (StreamReader file = File.OpenText(path))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                jsonArray = (JArray)JToken.ReadFrom(reader);
            }

            //JsonSerializer jsonSerializer = new JsonSerializer();
            //jsonSerializer.Converters.Add(_contentJsonConverter);

            List<NodeModel<TContent>> nodes = jsonArray.ToObject<List<NodeModel<TContent>>>();

            throw new NotImplementedException();
        }
    }
}
