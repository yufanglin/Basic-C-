using System;

namespace SwitchStatements
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Create a new Random object
			Random numberGenerator = new Random();

			// create the two integers to multiply
			int num01 = numberGenerator.Next(1, 11);
			int num02 = numberGenerator.Next(1, 11);

			// Ask the user the math problem
			Console.WriteLine("What is " + num01 + " times " + num02 + "?");

			// retrieve the user's answers
			int answer = Convert.ToInt32(Console.ReadLine());

			// Check if answer is correct
			if (answer == num01 * num02)
			{
				Console.WriteLine("Well done! Your answer is correct.");
			}
			else 
			{
				// randomize the response 
				int responseIndex = numberGenerator.Next(1,4);
				switch (responseIndex)
				{
					case 1:
						Console.WriteLine("Are you even trying?");
						break;
					case 2:
						Console.WriteLine("The answer was incorrect.");
						break;
					default:
						Console.WriteLine("You can do better than that.");
						break;
				}

				// compare the user answer with the correct answer
				int diff = num01 * num02 - answer;

				if (diff <= 2) 
				{
					Console.WriteLine("Your answer is very close to the actual answer");
				}
				else if (diff <= 5) 
				{ 
					Console.WriteLine("You answer is warm");
				}
				else if (diff <= 10) 
				{ 
					Console.WriteLine("You answer is pretty off"); 
				}
				else 
				{
					Console.WriteLine("How did you get your answer???");
				}
			}
		}
	}
}
