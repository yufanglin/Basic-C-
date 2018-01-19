using System;

namespace EnumsConsoleProject
{
	class MainClass
	{

		enum Breed
		{
			Bulldog, Boxer, Chihuahua, Briard
		};

		// Base class
		class Animal 
		{
			public string name;
			public int age;
			public float happiness;
		}

		// Derived class
		class Dog : Animal
		{
			public Breed breed;

			public Dog(string _name, int _age, float _happiness, Breed _breed) 
			{
				name = _name;
				age = _age;
				happiness = _happiness;

				breed = _breed;
			}

			public void InfoPrint() 
			{
				Console.WriteLine("{0, 5}", "- - - - - - - - - - - - - - - - - -");
				Console.WriteLine("{0, -20} {1, 5}", "Species:", "Dog");
				Console.WriteLine("{0, -20} {1, 5}\n", "Breed:", breed);
				Console.WriteLine("{0, -20} {1, 5}", "Name:", name);
				Console.WriteLine("{0, -20} {1, 5}", "Age:", age);
				Console.WriteLine("{0, -20} {1, 5}", "Happiness:", happiness);

			}
		}

		public static void Main(string[] args)
		{
			Dog hulk = new Dog("Hulk", 6, 0.7f, Breed.Boxer);
			hulk.InfoPrint();
		}
	}
}
