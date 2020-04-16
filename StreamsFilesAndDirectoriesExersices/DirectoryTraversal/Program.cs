using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> fileExtension = new Dictionary<string, Dictionary<string, long>>();

            DirectoryInfo directoryInfo = new DirectoryInfo(Environment.CurrentDirectory);
            var files = directoryInfo.GetFiles();

            foreach (var file in files)
            {
                var extension = file.Extension;

                if (!fileExtension.ContainsKey(extension))
                {
                    fileExtension.Add(extension, new Dictionary<string, long>());
                }

                fileExtension[extension].Add(file.Name, file.Length);
            }

            var sortedFile = fileExtension
                .OrderByDescending(e => e.Value.Count)
                .ThenBy(e => e.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            using (StreamWriter fileWriter = new StreamWriter(@"../../../Output/report.txt"))
            {
                foreach (var sortedFiles in sortedFile)
                {
                    fileWriter.WriteLine(sortedFiles.Key);

                    var currentFiles = sortedFiles.Value
                        .OrderBy(x => x.Value)
                        .ToDictionary(x => x.Key, x => x.Value);

                    foreach (var currentFile in currentFiles)
                    {
                        fileWriter.WriteLine($"--{currentFile.Key} - {(currentFile.Value / 1000.0):f3}kb");
                    }
                }
            }
        }
    }
}
