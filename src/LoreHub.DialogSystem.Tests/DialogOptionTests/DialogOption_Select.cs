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
            DialogNode currentDialogNode = new DialogNode(new List<DialogOption> { });
            DialogOption optionToSelect = new DialogOption("some", new DialogNode(new List<DialogOption> { }));

            void FuncToFire(object sender, DialogNode e)
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
            DialogNode realNextNode = null;
            DialogNode currentDialogNode = new DialogNode(new List<DialogOption> { });
            DialogNode nextNode = new DialogNode(new List<DialogOption> { });
            DialogOption optionToSelect = new DialogOption("some", nextNode);

            void FuncToFire(object sender, DialogNode e)
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
