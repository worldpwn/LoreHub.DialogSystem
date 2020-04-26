using LoreHub.DialogSystem.Core;
using LoreHub.DialogSystem.Core.DialogOptions;
using System;
using System.Collections.Generic;
using System.Linq;
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
            DialogOptionEnd<TestContent> dialogOption = new DialogOptionEnd<TestContent>(content);

            // Act
            DialogNode<TestContent> exitNoe = DialogNode<TestContent>.CreateExitNode(content: content, endOption: dialogOption);

            // Assert
            Assert.Single(exitNoe.DialogOptions);
            Assert.Equal(dialogOption, exitNoe.DialogOptions.FirstOrDefault());
            Assert.Equal(content, exitNoe.Content);
        }
    }
}
