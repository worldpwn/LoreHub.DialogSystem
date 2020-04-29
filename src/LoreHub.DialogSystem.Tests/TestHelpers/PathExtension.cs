﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LoreHub.DialogSystem.Tests.TestHelpers
{
    public static class PathExtension
    {
        public static string GetTestData(string fileName)
        {
            string startupPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string[] pathItems = startupPath.Split(Path.DirectorySeparatorChar);
            int pos = pathItems.Reverse().ToList().FindIndex(x => string.Equals("bin", x));
            string projectPath = String.Join(Path.DirectorySeparatorChar.ToString(), pathItems.Take(pathItems.Length - pos - 1));
            string pathToSimpleDialog = Path.Combine(projectPath, "TestData", fileName);

            return pathToSimpleDialog;
        }
    }
}
