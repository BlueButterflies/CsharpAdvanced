using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace FolderSize
{
    class Program
    {   /*Other code looks for size all directories in the folder*/

        static void Main(string[] args)
        {
            //var files = GetLength(@"C:\Users\Dsvk2\Desktop\C#Advanced\StreamsFilesAndDiretoriesLab\StreamFilesAndDiretories\FolderSize\TestFolder");
            //File.WriteAllText("Output.txt", files.ToString());

            var files = Directory.GetFiles(@"C:\Users\Dsvk2\Desktop\C#Advanced\StreamsFilesAndDiretoriesLab\StreamFilesAndDiretories\FolderSize\TestFolder");
            double totalLength = 0;

            foreach (var file in files) /*This code is for exersice*/
            {
                FileInfo infoFile = new FileInfo(file);

                totalLength += infoFile.Length;
            }
            totalLength = totalLength / 1024 / 1024;
            File.WriteAllText("Output.txt", totalLength.ToString());

        }
        //static long GetLength(string directory)
        //{
        //    long totalLegth = 0;

        //    var files = Directory.GetFiles(directory);

        //    var subDiretories = Directory.GetDirectories(directory);

        //    foreach (var subDirectory in subDiretories)
        //    {
        //        totalLegth += GetLength(subDirectory);
        //    }

        //    foreach (var file in files)
        //    {
        //        var infoFile = new FileInfo(file);

        //        totalLegth += infoFile.Length;
        //    }

        //    return totalLegth;
        //}
    }
}
