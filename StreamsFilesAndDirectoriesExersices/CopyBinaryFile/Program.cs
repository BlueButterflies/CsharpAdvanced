using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream readFile = new FileStream(@"../../../Resource/copied.png", FileMode.Open))
            using (FileStream writeFile = new FileStream(@"../../../Output/copyFile.png", FileMode.Create))
            {
                byte[] buffer = new byte[4096];

                while (true)
                {
                    var totalByte = readFile.Read(buffer, 0, buffer.Length);

                    if (totalByte == 0)
                    {
                        break;
                    }

                    writeFile.Write(buffer, 0, totalByte);
                }

            }

        }
    }
}
