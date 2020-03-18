using LoreHub.DialogSystem.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LoreHub.DialogSystem.Core.DialogOptions;

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
        [Fact]
        public void SimpleDialog_Shoulb_BePlayed()
        {
            //Arrange
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
                    new DialogOptionNext<TestContent>(content: new TestContent("Hi, I am fine."), nextNode: nodeTwo),
                    new DialogOptionNext<TestContent>(content: new TestContent("Hi, evrything is so bad."), nextNode: nodeThree)
                });

            Dialog<TestContent> dialog = Dialog<TestContent>.CreateNew()

            TestContent content = new TestContent();
            DialogNode<TestContent> nextDialogNode = new DialogNode<TestContent>(new List<DialogOptionNext<TestContent>> { });
            DialogOptionNext<TestContent> dialogOption = new DialogOptionNext<TestContent>(content: content, nextNode: nextDialogNode);
            List<DialogOptionNext<TestContent>> options = new List<DialogOptionNext<TestContent>> { dialogOption };

            // Act
            DialogNode<TestContent> dialogNode = new DialogNode<TestContent>(options);

            // Assert
            Assert.Equal(options, dialogNode.DialogOptions);
        }
    }
}
