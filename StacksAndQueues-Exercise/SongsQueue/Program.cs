using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] songs = Console.ReadLine().Split(", ");

            Queue<string> songsQueue = new Queue<string>(Console.ReadLine().Split(", "));

            //for (int i = 0; i < songs.Length; i++)
            //{
            //    songsQueue.Enqueue(songs[i]);
            //}
            while (songsQueue.Count > 0)
            {
                string line = Console.ReadLine();
                string[] songPart = line.Split();
                string command = songPart[0];

                if(command == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if(command == "Add")
                {
                    string songName = line.Substring(4);//Here it takes the whole sentence after the Add command

                    if (songsQueue.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(songName);
                    }
                }
                else if(command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
