using System;

namespace ClassesConsoleProject
{
	class Animal
	{
		// CLASS VARIABLES
		// A property that is shared between all instances
		public static int Count = 0;

		// All variables are public to access them outside of this class
		public string name;
		public int age;
		public float happiness;


		// CLASS CONSTRUCTORS
		public Animal() 
		{
			name = "Spotty";
			age = 6;
			happiness = 0.5f;

			Count++;
		}
		public Animal(string _name, int _age, float _happiness) 
		{
			// Set the animal properties
			name = _name;
			age = _age;
			happiness = _happiness;


			// increment animal count
			Count++;
		}

		// CLASS METHODS
		public void Print() 
		{ 
			// -- Prints out the Class's properties -- \\
			Console.WriteLine("Name: " + name);
			Console.WriteLine("Age: " + age);
			Console.WriteLine("Happiness: " + happiness);
		}

	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			// ---- CLASSES ---- \\
			// create a new instance of the Animal class
			Animal dog = new Animal();

			Console.WriteLine("\n---- Dog Info: ----");
			dog.Print();


			// Create another animal
			Animal cat = new Animal("Meme", 1, 0.8f);

			Console.WriteLine("\n---- Cat Info: ----");
			cat.Print();

			Console.WriteLine("\n---------------------");
			Console.WriteLine("Total Animals: " + Animal.Count);
		}
	}
}
