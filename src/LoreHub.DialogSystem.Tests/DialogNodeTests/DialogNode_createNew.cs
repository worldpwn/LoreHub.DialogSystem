using LoreHub.DialogSystem.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LoreHub.DialogSystem.Tests.DialogOptionTests
{
    public class DialogNode_createNew
    {
        [Fact]
        public void AllSet_Should_BeSet()
        {
            // Arrange
            TestContent content = new TestContent();
            DialogNode<TestContent> nextDialogNode = DialogNode<TestContent>.CreateNew(new List<DialogOption<TestContent>> { });
            DialogOption<TestContent> dialogOption = new DialogOption<TestContent>(content: content, nextNode: nextDialogNode);
            List<DialogOption<TestContent>> options = new List<DialogOption<TestContent>> { dialogOption };

            // Act
            DialogNode<TestContent> dialogNode = DialogNode<TestContent>.CreateNew(options);

            // Assert
            Assert.Equal(options, dialogNode.DialogOptions);
        }
    }
}
