using LoreHub.DialogSystem.Core;
using LoreHub.DialogSystem.Core.DialogOptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LoreHub.DialogSystem.Tests.DialogOptionTests
{
    public class DialogNode_CreateNew
    {
        [Fact]
        public void AllSet_Should_BeSet()
        {
            // Arrange
            TestContent content = new TestContent();
            DialogNode<TestContent> nextDialogNode = DialogNode<TestContent>.CreateNew(new List<DialogOptionNext<TestContent>> { });
            DialogOptionNext<TestContent> dialogOption = new DialogOptionNext<TestContent>(content: content, nextNode: nextDialogNode);
            List<DialogOptionNext<TestContent>> options = new List<DialogOptionNext<TestContent>> { dialogOption };

            // Act
            DialogNode<TestContent> dialogNode = DialogNode<TestContent>.CreateNew(options);

            // Assert
            Assert.Equal(options, dialogNode.DialogOptions);
        }
    }
}
