using LoreHub.DialogSystem.Core;
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
            DialogNode<TestContent> currentDialogNode = DialogNode<TestContent>.CreateNew(new List<DialogOption<TestContent>> { });
            DialogOption<TestContent> optionToSelect = new DialogOption<TestContent>(new TestContent(), DialogNode<TestContent>.CreateNew(new List<DialogOption<TestContent>> { }));

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
            DialogNode<TestContent> currentDialogNode = DialogNode<TestContent>.CreateNew(new List<DialogOption<TestContent>> { });
            DialogNode<TestContent> nextNode = DialogNode<TestContent>.CreateNew(new List<DialogOption<TestContent>> { });
            DialogOption<TestContent> optionToSelect = new DialogOption<TestContent>(new TestContent(), nextNode);

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
