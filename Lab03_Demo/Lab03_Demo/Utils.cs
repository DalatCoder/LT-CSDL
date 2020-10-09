using System;
using System.IO;
using System.Runtime.InteropServices;

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

        public static string GetPathTo(params string[] args)
        {
            string relativePath = String.Join("\\", args);
            return GetCurrentProjectDirectory() + "\\" + relativePath;
        }
    }
}
    