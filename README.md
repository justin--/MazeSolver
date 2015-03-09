# MazeSolver
uses c# to solve a maze image (must have a red start pixel, blue end pixel, black walls)


The working_directory contains sample mazes and their solutions
The MazeSolver directory contains the source code and executables of the c# program.

MazeSolverMain.cs takes care of command line actions, getting the input file path, output file path and opening
the image into a Bitmap class. The final solved Bitmap is written into the output file path.

PathFinder.cs takes a bitmap image and color specifications and performs breadth first search on it, and then draws 
the path from the end pixel to the start pixel.

MazeNode.cs just allows a linked list of visited nodes to be able to draw the path.
