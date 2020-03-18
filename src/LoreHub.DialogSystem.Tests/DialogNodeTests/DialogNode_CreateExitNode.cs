using LoreHub.DialogSystem.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LoreHub.DialogSystem.Tests.DialogOptionTests
{
    public class DialogNode_CreateExitNode
    {
        [Fact]
        public void Call_Should_CreateExitNode()
        {
            // Arrange
            TestContent content = new TestContent();
            List<DialogOption<TestContent>> options = new List<DialogOption<TestContent>> { dialogOption };
            DialogOption<TestContent> dialogOption = new DialogOption<TestContent>(content: content, nextNode: nextDialogNode);
            DialogNode<TestContent> nextDialogNode = DialogNode<TestContent>.CreateExitNode(dialogOption);

            // Act
            DialogNode<TestContent> dialogNode = DialogNode<TestContent>.CreateNew(options);

            // Assert
            Assert.Equal(options, dialogNode.DialogOptions);
        }
    }
}
