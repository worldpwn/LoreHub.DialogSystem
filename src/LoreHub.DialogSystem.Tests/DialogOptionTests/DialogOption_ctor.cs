using LoreHub.DialogSystem.Core;
using LoreHub.DialogSystem.Core.DialogOptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LoreHub.DialogSystem.Tests.DialogOptionTests
{
    public class DialogOption_ctor
    {
        [Fact]
        public void AllSet_Should_BeSet()
        {
            // Arrange
            TestContent content = new TestContent();
            DialogNode<TestContent> nextDialogNode = DialogNode<TestContent>.CreateNew(new List<DialogOptionNext<TestContent>> { });
            // Act
            DialogOptionNext<TestContent> dialogOption = new DialogOptionNext<TestContent>(content: content, nextNode: nextDialogNode);

            // Assert
            Assert.Equal(content, dialogOption.Content);
            Assert.Equal(nextDialogNode, dialogOption.NextNode);
        }

        [Theory]
        [InlineData(false, true)]
        [InlineData(true, false)]
        [InlineData(true, true)]
        public void OneOfParamIsNull_Should_Throw(
            bool contetIsNull,
            bool nextNodeIsNull
        )
        {
            // Arrange
            TestContent content = new TestContent();
            DialogNode<TestContent> nextDialogNode = DialogNode<TestContent>.CreateNew(new List<DialogOptionNext<TestContent>> { });
            if (contetIsNull) content = null;
            if (nextNodeIsNull) nextDialogNode = null;

            // Act
            Action action = () => new DialogOptionNext<TestContent>(content: content, nextNode: nextDialogNode);

            // Assert
            Assert.Throws<ArgumentNullException>(action);
        }

    }
}
