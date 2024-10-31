// Trey Walker, 10/30/24/ Maze

using System;

namespace MazeGame
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("In this program there will be a maze put on screen with the goal to get to the end.");
            
            string[] mapRows = File.ReadAllLines("map.txt");

            foreach (string row in mapRows)
            {
                Console.WriteLine(row);
            }
        }
    }
}


