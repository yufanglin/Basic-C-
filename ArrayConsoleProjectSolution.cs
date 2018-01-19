using System;
using System.Collections.Generic; 	// to use: lists

namespace ArrayConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// ---- INT ARRAY ---- \\
			Console.WriteLine("Int Array:");
			// create a new int array
			int[] numbers = new int[5];

			// set values in array
			numbers[0] = 12;
			numbers[1] = 3;
			numbers[2] = 5;

			// Print the second item in the array
			Console.WriteLine("Second number in number array: " + numbers[1]);

			Console.WriteLine("\nLooping through numbers array:");
			// Loop through array
			for (int i = 0; i < numbers.Length; i++)
			{
				// Print out each item in Console
				Console.WriteLine("Index: " + i + " | Value: " + numbers[i]);
			}

			// Loop using foreach
			Console.WriteLine("\nLooping through numbers array using FOREACH:");

			// in this loop, we are creating a clone of each number, so we cannot actually change each item in array
			foreach (int number in numbers)
			{
				Console.Write(number + ", ");
				// number = 5 will cause an error
			}


			// ---- STRING ARRAY ---- \\
			Console.WriteLine("\n\nString Arrays:");
			// Create a new string array
			string[] names = new string[3] {
				"Thom", "Mark", "Matt"
			};

			foreach (string name in names)
			{ 
				Console.Write(name + ", ");
			}


			// ---- LISTS ---- \\
			Console.WriteLine("\n\nLists:");

			// Only use lists when you don't know how many elements are going to be in it beforehand
			// Create numbers lists
			List<int> numbersList = new List<int>();

			// implement the list
			numbersList.Add(13);
			numbersList.Add(4);
			numbersList.Add(8);

			// Print out the second item in lists
			Console.WriteLine("Second element in list: " + numbersList[1]);

			Console.WriteLine("\nLooping through numbers list:");
			// Loop through list
			for (int i = 0; i<numbersList.Count; i++)
			{
				// Print out each item in Console
				Console.WriteLine("Index: " + i + " | Value: " + numbersList[i]);
			}

			Console.WriteLine("\nRemove second number from list:");
			// Remove number at index
			numbersList.RemoveAt(1);

			// Remove the first number that matches 4
			// numbersList.Remove(4);

			// Loop through list
			for (int i = 0; i<numbersList.Count; i++)
			{
				// Print out each item in Console
				Console.WriteLine("Index: " + i + " | Value: " + numbersList[i]);
			}


			// ---- Multidimensional Arrays: GRID ---- \\
			CreateGrid();

			// ---- Multidimensional Arrays: JAGGED ARRAYS ---- \\
		}


		public static void CreateGrid() 
		{
			// Create dimensions
			int width = 20;
			int height = 20;

			// Create 2-dimensional Array, if three add another comma
			int[,] grid = new int[width, height];

			grid[2, 3] = 3;

			// Loop through columns
			for (int x = 0; x < width; x++) 
			{ 
				// Loop through rows
				for (int y = 0; y < height; y++) 
				{
					// Assign a value to the value
					grid[x, y] = x + y;

					Console.Write(grid[x, y] + " ");
				}
				// Separate lines
				Console.WriteLine();
			}
		}

		public static void Create JaggedArrays() 
		{ 
			// Create dimensions
			int width = 20;
			int height = 20;

			// create an array of an array
			int[][] grid = new int[width][height];


		}
	}
}
