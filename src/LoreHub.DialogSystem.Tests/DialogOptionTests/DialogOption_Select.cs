using LoreHub.DialogSystem.Core;
using LoreHub.DialogSystem.Core.DialogOptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LoreHub.DialogSystem.Tests.DialogOptionTests
{
    public class DialogOption_Select
    {
        [Fact]
        public void SelectOption_Should_RaiseEvent()
        {
            // Arrange
            bool isFired = false;
            DialogNode<TestContent> currentDialogNode = DialogNode<TestContent>.CreateNew(content: new TestContent(), dialogOptions: new List<DialogOptionNext<TestContent>> { });
            DialogOptionNext<TestContent> optionToSelect = new DialogOptionNext<TestContent>(new TestContent(), DialogNode<TestContent>.CreateNew(content: new TestContent(), dialogOptions: new List<DialogOptionNext<TestContent>> { }));

            void FuncToFire(object sender, DialogNode<TestContent> e)
            {
                isFired = true;
            }
            optionToSelect.SelectEvent += FuncToFire;


            // Act
            optionToSelect.Select();

            // Assert
            Assert.True(isFired);
        }

        [Fact]
        public void SelectOption_Should_ContaintNextNode()
        {
            // Arrange
            DialogNode<TestContent> realNextNode = null;
            DialogNode<TestContent> currentDialogNode = DialogNode<TestContent>.CreateNew(content: new TestContent(), dialogOptions: new List<DialogOptionNext<TestContent>> { });
            DialogNode<TestContent> nextNode = DialogNode<TestContent>.CreateNew(content: new TestContent(), dialogOptions: new List<DialogOptionNext<TestContent>> { });
            DialogOptionNext<TestContent> optionToSelect = new DialogOptionNext<TestContent>(new TestContent(), nextNode);

            void FuncToFire(object sender, DialogNode<TestContent> e)
            {
                realNextNode = e;
            }
            optionToSelect.SelectEvent += FuncToFire;


            // Act
            optionToSelect.Select();

            // Assert
            Assert.Equal(nextNode, realNextNode);
        }
    }
}
