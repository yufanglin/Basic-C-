using System;

namespace Calculator
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Start:
			// Create a variable for user input
			double num01;      // implicit variable declaration if "var", explicit if it is something like "int"
			double num02;

			// ------ Multiply ------ \\
			// --- First Input --- \\
			// Ask the user to input something
			Console.Write("Please input an integer to be multiplied: ");

			// Read the user input
			num01 = Convert.ToDouble(Console.ReadLine());        // the user will input an integer, so we need to convert


			// --- Second Input --- \\
			// Ask th user to input another integer
			Console.Write("Please input another integer to be muliplied: ");
			// Read the user input
			num02 = Convert.ToDouble(Console.ReadLine());


			// --- Calculate --- \\
			double multiply = num01 * num02;

			// Print out the multiplied integer
			Console.WriteLine("The answer: " + multiply);


			// ------ Divide ------ \\
			// --- First Input --- \\
			// Tell user to input number
			Console.Write("\nEnter the number to be divided: ");
			// retrieve user's input
			num01 = Convert.ToDouble(Console.ReadLine());

			// --- Second Input --- \\
			// Tell user to input another number
			Console.Write("Enter the number to divide by: ");
			// Retrieve user's input
			num02 = Convert.ToDouble(Console.ReadLine());

			// --- Calculate --- \\
			// divide
			double division = num01 / num02;
			// Print
			Console.WriteLine("The answer: " + division);

			// ------ Repeat ------ \\
			Console.ReadKey();  // wait for user to press a key
			Console.WriteLine();	// make a new line
			goto Start;		// jump to start;
		}
	}
}
