using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoreHub.DialogSystem.Core;
using LoreHub.DialogSystem.Core.Builder;
using LoreHub.DialogSystem.Core.Builder.Models;
using LoreHub.DialogSystem.Core.ContentVariants.AsString;
using LoreHub.DialogSystem.Core.DialogOptions;
using Xunit;

namespace LoreHub.DialogSystem.Tests.Builder.DialogBuilderTests
{
    public class DialogBuilder_CreateNodeFromModel
    {
        [Fact]
        public void PassModel_Should_CreateDialogNode()
        {
            OptionModel<ContentAsString> optionModel = new OptionModel<ContentAsString>(
                id: Guid.NewGuid(),
                content: new ContentAsString("Some"),
                nextNodeId: Guid.NewGuid());

            DialogNode<ContentAsString> dialogNode = DialogNode<ContentAsString>.CreateExitNode(
                id: Guid.NewGuid(),
                content: new ContentAsString("end"),
                endOption: new DialogOptionEnd<ContentAsString>(Guid.NewGuid(), new ContentAsString("end option")));

            DialogBuilder<ContentAsString> dialogBuilder = new DialogBuilder<ContentAsString>();

            NodeModel<ContentAsString> nodeModel = new NodeModel<ContentAsString>(
               id: Guid.NewGuid(),
               content: new ContentAsString("Some"),
               options: new List<OptionModel<ContentAsString>>() { optionModel });

            DialogNode<ContentAsString> node = dialogBuilder.CreateNodeFromModel(nodeModel);

            Assert.Equal(nodeModel.Id, node.Id);
            Assert.Equal(nodeModel.Content, node.Content);
            Assert.Equal(nodeModel.Options.FirstOrDefault().Id, node.DialogOptions.FirstOrDefault().Id);
        }
    }
}
