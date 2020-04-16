using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;
namespace SliceFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 4;

            using (FileStream text = new FileStream (@"C:\Users\Dsvk2\Desktop\C#Advanced\StreamsFilesAndDiretoriesLab\StreamFilesAndDiretories\SliceFile\Input.txt", FileMode.Open))
            {
                var dividedTextInFourParts = (int)Math.Ceiling((double)text.Length / count);
                byte[] buffer = new byte[dividedTextInFourParts];

                for (int i = 1; i <= count; i++)
                {
                    using (var output = new FileStream($"Output-{i}.txt", FileMode.Create, FileAccess.Write))
                    {
                        int readedBytes = text.Read(buffer, 0, dividedTextInFourParts);
                        output.Write(buffer, 0, readedBytes);
                    }
                }


            }
        }
    }
}
