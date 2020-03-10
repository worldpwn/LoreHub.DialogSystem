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
            DialogNode? realNextNode = null;
            DialogNode currentDialogNode = new DialogNode(new List<DialogOption> { });

            DialogNode expectedNextNode = new DialogNode(new List<DialogOption> { });

            DialogOption selectedOption = new DialogOption("some", expectedNextNode);

            Func<object, EventArgs, Action> func = Click;

            selectedOption.SelectEvent += Click;


            // Act


            // Assert
            Assert.Equal(expectedNextNode, realNextNode);
        }

        private void Click(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
        }
    }
}
