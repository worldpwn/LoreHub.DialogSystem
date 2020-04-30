using System;
using System.Collections.Generic;
using System.Text;
using LoreHub.DialogSystem.Core;
using LoreHub.DialogSystem.Core.Builder;
using LoreHub.DialogSystem.Core.Builder.Models;
using LoreHub.DialogSystem.Core.ContentVariants.AsString;
using LoreHub.DialogSystem.Core.DialogOptions;
using Xunit;

namespace LoreHub.DialogSystem.Tests.Builder.DialogBuilderTests
{
    public class DialogBuilder_CreateOptionFromModel
    {
        [Fact]
        public void PassModelWithNext_Should_CreateDialogOptionNext()
        {
            OptionModel<ContentAsString> optionModel = new OptionModel<ContentAsString>(
                id: Guid.NewGuid(),
                content: new ContentAsString("Some"),
                nextNodeId: Guid.NewGuid());

            DialogNode<ContentAsString> dialogNode = DialogNode<ContentAsString>.CreateExitNode(
                content: new ContentAsString("end"),
                endOption: new DialogOptionEnd<ContentAsString>(Guid.NewGuid(), new ContentAsString("end option")));

            DialogBuilder<ContentAsString> dialogBuilder = new DialogBuilder<ContentAsString>();
            
            IDialogOption<ContentAsString> option = dialogBuilder.CreateOptionFromModel(optionModel, dialogNode);

            Assert.IsType<DialogOptionNext<ContentAsString>>(option);
            Assert.Equal(optionModel.Id, option.Id);
            Assert.Equal(optionModel.Content, option.Content);
        }

        [Fact]
        public void PassModelWihtoutNext_Should_CreateDialogOptionNext()
        {
            OptionModel<ContentAsString> optionModel = new OptionModel<ContentAsString>(
                id: Guid.NewGuid(),
                content: new ContentAsString("Some"),
                nextNodeId: null);

            DialogBuilder<ContentAsString> dialogBuilder = new DialogBuilder<ContentAsString>();

            IDialogOption<ContentAsString> option = dialogBuilder.CreateOptionFromModel(optionModel, null);

            Assert.IsType<DialogOptionEnd<ContentAsString>>(option);
            Assert.Equal(optionModel.Id, option.Id);
            Assert.Equal(optionModel.Content, option.Content);
        }
    }
}
