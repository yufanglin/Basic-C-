using System;

namespace Method
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int result = Add(3, 4);
			Console.WriteLine(result);
			// Knows which add you mean
			Add(1, 2, 3);

		}

		public static int Add(int num01, int num02) 
		{
			return num01 + num02;
		}

		public static void Add(int num01, int num02, int num03) 
		{
			Console.WriteLine(num01 + num02 + num03);
		}


	}
}
