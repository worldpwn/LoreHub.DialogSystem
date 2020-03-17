using LoreHub.DialogSystem.Core;
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
            DialogNode<TestContent> nextDialogNode = new DialogNode<TestContent>(new List<DialogOption<TestContent>> { });
            // Act
            DialogOption<TestContent> dialogOption = new DialogOption<TestContent>(content: content, nextNode: nextDialogNode);

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
            DialogNode<TestContent> nextDialogNode = new DialogNode<TestContent>(new List<DialogOption<TestContent>> { });
            if (contetIsNull) content = null;
            if (nextNodeIsNull) nextDialogNode = null;

            // Act
            Action action = () => new DialogOption<TestContent>(content: content, nextNode: nextDialogNode);

            // Assert
            Assert.Throws<ArgumentNullException>(action);
        }

    }
}
