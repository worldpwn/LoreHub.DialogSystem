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
            Content content = new Content();
            DialogNode nextDialogNode = new DialogNode(new List<DialogOption> { });
            // Act
            DialogOption dialogOption = new DialogOption(content: content, nextNode: nextDialogNode);

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
            Content content = new Content();
            DialogNode nextDialogNode = new DialogNode(new List<DialogOption> { });
            if (contetIsNull) content = null;
            if (nextNodeIsNull) nextDialogNode = null;

            // Act
            Action action = () => new DialogOption(content: content, nextNode: nextDialogNode);

            // Assert
            Assert.Throws<ArgumentNullException>(action);
        }

    }
}
