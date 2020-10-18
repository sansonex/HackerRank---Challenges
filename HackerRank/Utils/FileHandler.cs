using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace HackerRank.Utils
{
    public static class FileHandler
    {
        public static string[] ReadFile(string challengeName, string fileName)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"challenges\{challengeName}\{fileName}.txt");

            return File.ReadAllLines(path);
        }
    }
}
