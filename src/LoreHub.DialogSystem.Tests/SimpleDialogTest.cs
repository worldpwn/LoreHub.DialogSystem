using LoreHub.DialogSystem.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LoreHub.DialogSystem.Core.DialogOptions;
using System.Linq;

namespace LoreHub.DialogSystem.Tests.DialogOptionTests
{
    public class SimpleDialogTest
    {
        /// <summary>
        /// (1) Hello! What's up?
        /// - Hi, I am fine. => 2
        /// - Hi, evrything is so bad. => 3
        ///
        /// (2) So good.
        /// - Bye. => end
        ///
        /// (3) I am sorry for you.
        /// - Yeah. => end
        /// </summary>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void SimpleDialog_Shoulb_BePlayed(bool isFirstBranch)
        {
            //Arrange
            TestContent optionOneContent = new TestContent("Hi, I am fine.");
            TestContent optionTwoContent = new TestContent("Hi, evrything is so bad.");


            DialogNode<TestContent> nodeThree = DialogNode<TestContent>.CreateExitNode(
                content: new TestContent("I am sorry for you."),
                endOption: new DialogOptionEnd<TestContent>(new TestContent("Yeah")));

            DialogNode<TestContent> nodeTwo = DialogNode<TestContent>.CreateExitNode(
                content: new TestContent("So good."),
                endOption: new DialogOptionEnd<TestContent>(new TestContent("Bye")));

            DialogNode<TestContent> nodeOne = DialogNode<TestContent>.CreateNew(
                content: new TestContent("Hello! What's up?"),
                dialogOptions: new List<IDialogOption<TestContent>>
                {
                    new DialogOptionNext<TestContent>(content: optionOneContent, nextNode: nodeTwo),
                    new DialogOptionNext<TestContent>(content: optionTwoContent, nextNode: nodeThree)
                });

            Dialog<TestContent> dialog = Dialog<TestContent>.CreateNew(startNode: nodeOne);

            // Act && Assert
            if (isFirstBranch)
            {
                dialog.CurrentNode.DialogOptions.FirstOrDefault(o => o.Content == optionOneContent).Select();
                Assert.Equal(nodeTwo, dialog.CurrentNode);
            }
            else
            {
                dialog.CurrentNode.DialogOptions.FirstOrDefault(o => o.Content == optionTwoContent).Select();
                Assert.Equal(nodeThree, dialog.CurrentNode);
            }
        }
    }
}
