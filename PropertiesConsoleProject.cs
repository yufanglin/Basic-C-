using System;

namespace PropertiesConsoleProject
{
	class MainClass
	{
		public class Player 
		{
			// Create private property
			private int _health = 100;

			// Create getters and setters
			public int health 
			{
				get 
				{
					return _health;
				}

				set
				{
					// prevent health from going below 0 or above 100
					if (value <= 0)
					{
						_health = 0;
					}
					else if (value >= 100)
					{
						_health = 100;
					}
					else
					{
						_health = value;
					}
				}
			}

			//public void Damage(int _dmg) 
			//{
			//	_health -= _dmg;
			//}
		}
		public static void Main(string[] args)
		{
			/// ----- Sample of a Getter in C# classes -----
			// Get the current time, a get method, so cannot change
			DateTime curTime = DateTime.Now;

			Console.WriteLine("{0, -20} {1, 5}", "Current Time:", curTime);


			/// ----- using own getter and setter -------

			// Create new player object
			Player tom = new Player();

			// Set the health using setter
			tom.health -= 200;
			// Get the health from getter property 
			Console.WriteLine("{0, -20} {1, 10} damage", "Tom takes:", "200");
			Console.WriteLine("{0, -20} {1, 10} hp", "Tom's health:", tom.health);

			tom.health += 400;
			Console.WriteLine("{0, -20} {1, 10} hp", "Tom got healed for:", "400");
			Console.WriteLine("{0, -20} {1, 10} hp", "Tom's health:", tom.health);

			tom.health = 50;
			Console.WriteLine("{0, -20} {1, 10} hp", "Tom ate spoiled food:", "-half max");
			Console.WriteLine("{0, -20} {1, 10} hp", "Tom's health:", tom.health);

		}
	}
}
