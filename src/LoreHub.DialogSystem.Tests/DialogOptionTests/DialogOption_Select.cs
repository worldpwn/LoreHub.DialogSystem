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

            void FuncToFire(object sender, EventArgs e)
            {
                isFired = true;
            }
            optionToSelect.SelectEvent += FuncToFire;


            // Act
            optionToSelect.Select();

            // Assert
            Assert.True(isFired);
        }
    }
}
