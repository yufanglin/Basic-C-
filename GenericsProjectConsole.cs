using System;
using System.Collections.Generic;	// For Dictionaries, lists, etc

namespace GenericsProjectConsole
{
	// when we don't know the type of object we use generics

	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("\n----------------Generic Class---------------\n");
			KeyValuePair<string, int> meaning = new KeyValuePair<string, int>("Life", 42);
			meaning.Print();

			Console.WriteLine("\n--------------Generic Collection------------\n");

			Dictionary<string, int> prices = new Dictionary<string, int>(5);

			prices.Add("watermelon", 5);
			prices.Add("car", 100000);
			Console.WriteLine("{0,-35} {1,15}","Watermelon:", "$"+prices["watermelon"]);
			Console.WriteLine("{0,-35} {1,15}","Car:", "$"+prices["car"]);

			Console.WriteLine("\n----------Generic Method: Equal Values------------\n");
			Console.WriteLine("{0, -35} {1, 5}", "10 == 2:", Utility.CompareValues(10, 2));
			Console.WriteLine("{0, -35} {1, 5}", "10 == 10:", Utility.CompareValues(10, 10));
			Console.WriteLine("{0, -35} {1, 5}", "hello == 10:", Utility.CompareValues("hello", 10));
			Console.WriteLine("{0, -35} {1, 5}", "hello == world:", Utility.CompareValues("hello", "world"));
			Console.WriteLine("{0, -35} {1, 5}", "hello == hello:", Utility.CompareValues("hello", "hello"));

			Console.WriteLine("\n----------Generic Method: Equal Types------------\n");
			Console.WriteLine("{0, -35} {1, 5}", "10 == 2:", Utility.CompareTypes(10, 2));
			Console.WriteLine("{0, -35} {1, 5}", "hello == 10:", Utility.CompareTypes("hello", 10));
			Console.WriteLine("{0, -35} {1, 5}", "hello == world:", Utility.CompareTypes("hello", "world"));
		}
	}

	class KeyValuePair<TKey, TValue>
	{
		public TKey key;
		public TValue value;

		public KeyValuePair(TKey _key, TValue _value)
		{
			key = _key;
			value = _value;
		}

		public void Print()
		{
			Console.WriteLine("Key: " + key.ToString());
			Console.WriteLine("Value: " + value.ToString());
		}
	}

	class Utility
	{
		// Create a generic method in a non generic class
		public static bool CompareValues<T01, T02>(T01 value01, T02 value02)
		{
			return value01.Equals(value02);
		}

		public static bool CompareTypes<T01, T02>(T01 type01, T02 type02)
		{
			return typeof(T01).Equals(typeof(T02));
		}
	}
}
