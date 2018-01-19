using System;

namespace FirstConsoleProject
{
	class MainClass
	{
		public static void Main(string[] args) 		// this is a method called "Main". It is called when the program starts
		{
			Console.WriteLine("My name is __, and my age is 23. What about you?: ");
			var userInputNameAge = Console.ReadLine();

			Console.WriteLine("My favorite color is dark purple, you?: ");
			var userFavColor = Console.ReadLine();

			var message = "Your name and age is: " + userInputNameAge + ". And your favorite color is: " + userFavColor;

			Console.WriteLine(message);
		}
	}
}
