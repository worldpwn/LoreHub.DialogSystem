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
        public Dialog<TContent> CreateFromJSON(string path)
        {
            JArray jsonArray;
            using (StreamReader file = File.OpenText(path))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                jsonArray = (JArray)JToken.ReadFrom(reader);
            }

            List<NodeModel<TContent>> nodeModels = jsonArray.ToObject<List<NodeModel<TContent>>>();
            NodeModel<TContent> startNode = nodeModels[0];

            

            List<DialogNode<TContent>> nodes = new List<DialogNode<TContent>>();

        

            foreach (NodeModel<TContent> model in nodeModels)
            {


                //nodes.Add(
                //    DialogNode<TContent>.CreateFromModel(
                //        id: model.Id,
                //        content: model.Content,
                //        dialogOptions: CreateOptionFromModel(
                //            model: null,
                //            nextNode: null));
                //    //CreateNodeFromModel(node)); ;
            }

            Dialog<TContent> dialog = Dialog<TContent>.CreateNew(nodes[0]);

            throw new NotImplementedException();
        }

        public DialogNode<TContent> CreateNodeFromModel(NodeModel<TContent> model)
        {
            //if (model is null) throw new ArgumentNullException(nameof(model));

            //return DialogNode<TContent>.CreateFromModel(
            //    id: model.Id,
            //    content: model.Content,
            //    dialogOptions: mode)
            throw new NotImplementedException();
        }

        public IDialogOption<TContent> CreateOptionFromModel(OptionModel<TContent> model, DialogNode<TContent> nextNode)
        {
            if (model is null) throw new ArgumentNullException(nameof(model));
            if (!(model.NextNodeId is null) && nextNode is null) throw new ArgumentException($"You cannot create option if {nameof(nextNode)} is null but {nameof(model)} contains id to next node.");

            if (nextNode is null)
                return new DialogOptionEnd<TContent>(model.Id, model.Content);
            else
                return new DialogOptionNext<TContent>(model.Id, model.Content, nextNode);
        }
    }
}
