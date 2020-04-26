using System;
using System.Collections.Generic;
using System.Text;

namespace LoreHub.DialogSystem.Tests
{
   internal class TestContent : IContent
   {
      public string Text { get; private set; }

      public TestContent()
      {
         this.Text = string.Empty;
      }

      public TestContent(string text)
      {
         this.Text = text;
      }
   }
}
