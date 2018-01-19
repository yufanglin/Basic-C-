using System;

namespace WhileLoops
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// ----- First Attempt: Basic
			int i = 0;
			while (i <= 10)
			{
				Console.Write(i + ", ");
				i++;
			}

			Console.WriteLine("\nRolling Dice:");

			// ----- Second Attempt: Dice
			// Create a random generator for the a dice
			Random dice = new Random();

			// Create attempt variables
			int numberOfAttempts = 0;
			int attempt = 0;

			// Roll dice until 6 is rolled
			while (attempt != 6) 
			{
				// Roll dice
				attempt = dice.Next(1, 7);
				// Print out the attempt
				Console.WriteLine("You rolled a: " + attempt);
				// increment attempts
				numberOfAttempts++;
			}

			Console.WriteLine("It took you " + numberOfAttempts + " attempts to roll a 6.");

			// ------ Do-While Loop
			// reset stats
			numberOfAttempts = 0;
			attempt = 0;

			Console.WriteLine("\nRolling Dice Again!:");

			do
			{
				// Roll dice
				attempt = dice.Next(1, 7);
				// Print out the attempt
				Console.WriteLine("You rolled a: " + attempt);
				// increment attempts
				numberOfAttempts++;
			}
			while (attempt != 6);

			Console.WriteLine("It took you " + numberOfAttempts + " attempts to roll a 6.");
		}
	}
}
