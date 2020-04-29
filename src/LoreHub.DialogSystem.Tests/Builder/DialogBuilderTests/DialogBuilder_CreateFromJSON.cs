using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using LoreHub.DialogSystem.Core.Builder;
using LoreHub.DialogSystem.Core.ContentVariants.AsString;
using LoreHub.DialogSystem.Tests.TestHelpers;
using Xunit;

namespace LoreHub.DialogSystem.Tests.Builder.DialogBuilderTests
{
    public class DialogBuilder_CreateFromJSON
    {
        [Fact]
        public void SimpleDialog_Should_BuildFrom_Json()
        {
            DialogBuilder<ContentAsString> dialogBuilder = new DialogBuilder<ContentAsString>();
            string pathToSimpleDialog = PathExtension.GetTestData("SimpleDialog.json");

            dialogBuilder.CreateFromJSON(pathToSimpleDialog);
  
        }
    }
}
