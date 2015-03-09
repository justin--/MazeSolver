using System;
using System.Drawing;

namespace MazeSolver
{
	// Handles command line inputs, opens the image to pass to PathFinder
	// sets the color requirements for the maze
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (args.Length != 2) 
			{
				Console.WriteLine ("Usage: MazeSolver.exe \"pathToMaze\" \"pathToSolution\"");
				System.Environment.Exit(1);
			}

			// Get the file names that will be working on from command line
			string inputPath = args [0];
			string outputPath = args [1];

			// For this project these define the start, end, wall and path colors for the maze
			// Just change these if you want to solve a maze with different requirements
			Color start = Color.Red;
			Color end = Color.Blue;
			Color wall = Color.Black;
			Color path = Color.Green;

			// Load the maze from the first argument filename
			Bitmap mazeImage = new Bitmap(inputPath);

			// initialize path finder with the image and colors to operate with
			PathFinder pf = new PathFinder (mazeImage, start, end, wall, path);

			// get the solved maze bitmap from pathfinder
			mazeImage = pf.SolveMaze ();
			if (mazeImage == null) 
			{
				Console.WriteLine ("Could not solve maze");
			} 
			else 
			{
				Console.WriteLine ("Solved the maze");
				// Save the solved maze image into the output file path
				mazeImage.Save (outputPath);
			}
		}
	}
}
