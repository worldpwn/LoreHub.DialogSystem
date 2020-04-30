using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using LoreHub.DialogSystem.Core.Builder.Models;
using LoreHub.DialogSystem.Core.DialogOptions;
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

            List<NodeModel<TContent>> nodeModels = jsonArray.ToObject<List<NodeModel<TContent>>>();

            //List<DialogNode<TContent>> nodes = new List<DialogNode<TContent>>();
            //foreach (NodeModel<TContent> node in nodeModels)
            //{
            //    nodes.Add(DialogNode<TContent>.CreateNew)
            //}

           // Dialog<TContent> dialog = Dialog<TContent>.CreateNew(nodeModels[0]);

            throw new NotImplementedException();
        }

        public DialogNode<TContent> CreateFromModel(NodeModel<TContent> model)
        {
            throw new NotImplementedException();
        }

        public IDialogOption<TContent> CreateFromModel(OptionModel<TContent> model)
        {
            throw new NotImplementedException();
        }
    }
}
