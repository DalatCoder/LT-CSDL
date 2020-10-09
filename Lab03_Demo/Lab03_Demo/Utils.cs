using System;
using System.IO;

namespace Lab03_Demo
{
    public static class Utils
    {
        public static string GetCurrentProjectDirectory()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            return projectDirectory;
        }
    }
}
