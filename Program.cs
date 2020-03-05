using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\tMedia Player Interface Demo!");

            var mediaPlayer = new DVDPlayer();

            Console.WriteLine($"\tstreaming from: {mediaPlayer.DeviceName} totally rocks!");
            mediaPlayer.Pause();

            while (true)
            {
                Console.WriteLine("\tPush 'Up-Arrow' to Play");
                Console.WriteLine("\tPush '[Spacebar]' to Pause");
                Console.WriteLine("\tPush 'R' to Rewind");
                Console.WriteLine("\tPush 'F' to FFwd");
                Console.WriteLine("\tPush 'S' to Stop");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.F:
                        mediaPlayer.Ffwd();
                        break;
                    case ConsoleKey.R:
                        mediaPlayer.Rewind();
                        break;
                    case ConsoleKey.S:
                        mediaPlayer.Stop();
                        break;
                    case ConsoleKey.UpArrow:
                        mediaPlayer.Play();
                        break;
                    case ConsoleKey.Spacebar:
                        mediaPlayer.Pause();
                        break;
                }

            }
        }
    }
}
