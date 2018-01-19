using System;

namespace InheritanceConsoleProject
{
	class MainClass
	{

		// Create the base class example
		class Animal 
		{
			/*
			 * This is the base class other animal classes will inherit from 
			 */

			// Base properties
			public string name;
			public int age;
			public float happiness;

			// Base Function
			public void PrintBase() 
			{
				/*
				 * Prints the base information 
				 */

				Console.WriteLine("{0, -20} {1, 5}", "Name:", name);
				Console.WriteLine("{0, -20} {1, 5}", "Age:", age);
				Console.WriteLine("{0, -20} {1, 5}", "Happiness:", happiness);
			}
		}

		// Create a dog class that inherits from the animal class
		class Dog : Animal
		{
			// Dog Properties
			public string type = "Dog";
			public int spotCount;

			// Default Constructor 
			public Dog() 
			{
				name = "Spotty";
				age = 6;
				// If there are two happiness, and you want to access Animal's then use base.happiness instead
				happiness = 0.5f;
				spotCount = 25;
			}

			// Custom Constructor
			public Dog(string _name, int _age, float _happiness, int _spotCount) 
			{
				name = _name;
				age = _age;
				happiness = _happiness;
				spotCount = _spotCount;
			}

			// Prints Dog info header
			public void PrintInfoHeader()
			{ 
				Console.WriteLine("\n{0, 5}","- - - - - - - - - - - - - - - - - -");
				Console.WriteLine("{0, -20} {1, 5}\n", "Type:", type);
				PrintBase();
			}

			// Prints All Dog info
			public void PrintInfo() 
			{
				PrintInfoHeader();
				Console.WriteLine("{0, -20} {1, 5}", "Spot Count:", spotCount);
			}

			public void Bark()
			{
				happiness += 0.1f;
				Console.WriteLine("\n{0, -20} {1, 5}","WUF! Happiness +1:", happiness);

			}
		}

		class Cat : Animal
		{
			// Dog Properties
			public string type = "Cat";
			public float cuteness;


			// Default Constructor 
			public Cat()
			{
				name = "Mimi";
				age = 1;
				happiness = 0.7f;
				cuteness = 0.9f;
			}

			// Custom Constructor
			public Cat(string _name, int _age, float _happiness, float _cuteness)
			{
				name = _name;
				age = _age;
				happiness = _happiness;
				cuteness = _cuteness;
			}


			// Prints Cat info Header
			public void PrintInfoHeader()
			{
				Console.WriteLine("\n{0, 5}", "- - - - - - - - - - - - - - - - - -");
				Console.WriteLine("{0, -20} {1, 5}\n", "Type:", type);
				PrintBase();
			}

			// Print all Cat info
			public void PrintInfo() 
			{
				PrintInfoHeader();
				Console.WriteLine("{0, -20} {1, 5}", "Cuteness:", cuteness);
			}

			public void Meow() 
			{
				happiness += 0.1f;
				Console.WriteLine("\n{0, -20} {1, 5}", "MEOW! Happiness +1:", happiness);
			}
		}

		public static void Main(string[] args)
		{
			// Default
			Dog spotty = new Dog();
			spotty.PrintInfo();
			spotty.Bark();

			Cat mimi = new Cat();
			mimi.PrintInfo();
			mimi.Meow();

			// Custom
			Cat heisenberg = new Cat("Heisenberg", 13, 0.3f, 0.4f);
			heisenberg.PrintInfo();

			Dog boxy = new Dog("Boxy", 3, 0.4f, 3);
			boxy.PrintInfo();

		}
	}
}
