using System;

namespace IfStatements
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create reference to random class
			var random = new Random();
			// Create two random numbers
			double num01 = random.Next(0, 100);
			double num02 = random.Next(0, 100);

			// Ask the user's age
			Console.Write("What is " + num01 + " divided by " + num02 + " to the second decimal? : " );
			// Store the age of the user
			double answer = Convert.ToDouble(Console.ReadLine());

			// Check if the user is legally an adult
			if (answer == Math.Round(num01 / num02, 2))
			{
				Console.WriteLine("That is correct!");
			}
			else 
			{
				Console.WriteLine("Try again!");
			}
		}
	}
}
