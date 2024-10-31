// Trey Walker, 10/30/24/ Maze

using System;
using System.Diagnostics;

namespace MazeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mapRows = File.ReadAllLines("map.txt");

            Console.Clear();

            foreach (string row in mapRows)
            {
                Console.WriteLine(row);
            }

            Console.SetCursorPosition(0, 0);
            static void TryMove(ConsoleKey key, string[] mapRows)
        {
            int newTop = Console.CursorTop;
            int newLeft = Console.CursorLeft;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    newTop--;
                    break;
                case ConsoleKey.DownArrow:
                    newTop++;
                    break;
                case ConsoleKey.LeftArrow:
                    newLeft--;
                    break;
                case ConsoleKey.RightArrow:
                    newLeft++;
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }

            if (newTop >= 0 && newTop < mapRows.Length && newLeft >= 0 && newLeft < mapRows[newTop].Length && mapRows[newTop][newLeft] != '#')
            {
                Console.SetCursorPosition(newLeft, newTop);
            }
        }
    }
}
}