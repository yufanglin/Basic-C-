using System;

namespace InterfacesConsoleProject
{
	class MainClass
	{
		/// <summary>
		///  Interfaces are like tags to add to a class.
		///  A class can have several of these "tags"
		/// </summary>


		interface IItem
		{
			string name { get; set; }
			int goldValue { get; set; }

			void Equip();
			void Sell();
		}

		interface IDamagable
		{
			int durability { get; set; }

			void TakeDamage(int _amount);
		}

		interface IPartOfQuest
		{
			void TurnIn();
		}

		class Sword : IItem, IDamagable, IPartOfQuest
		{
			// Item interface properties
			public string name { get; set; }
			public int goldValue { get; set; }

			// Damagable interface properties
			public int durability { get; set; }

			// Constructor
			public Sword(string _name)
			{
				name = _name;
				goldValue = 100;
				durability = 30;
			}

			// Item interface Methods
			public void Equip()
			{
				Console.WriteLine("{0, 10} equipped.", name);
			}

			public void Sell()
			{
				Console.WriteLine("{0, -35} {1, 5} gold", name + " sold for:", goldValue);
			}

			// Damagable Interface Methods
			public void TakeDamage(int _dmg)
			{
				durability -= _dmg;
				Console.WriteLine("{0, -35} {1, 5} damage", name + " took:", _dmg);
				Console.WriteLine("{0, -35} {1, 5}", name + " has a durability of:", durability);
			}

			// Part Of Quest Interface Methods
			public void TurnIn()
			{
				Console.WriteLine("{0, -35} {1, 5}", name, " turned in.");
			}
		}

		class Axe : IItem, IDamagable
		{
			// Item interface properties
			public string name { get; set; }
			public int goldValue { get; set; }

			// Damagable interface properties
			public int durability { get; set; }

			// Constructor
			public Axe(string _name)
			{
				name = _name;
				goldValue = 500;
				durability = 80;
			}

			// Item interface Methods
			public void Equip()
			{
				Console.WriteLine("{0, 10} equipped.", name);
			}

			public void Sell()
			{
				Console.WriteLine("{0, -35} {1, 5} gold", name + " sold for:", goldValue);
			}

			// Damagable Interface Methods
			public void TakeDamage(int _dmg)
			{
				durability -= _dmg;
				Console.WriteLine("{0, -35} {1, 5} damage", name + " took:", _dmg);
				Console.WriteLine("{0, -35} {1, 5}", name + " has a durability of:", durability);
			}
		}
			

		public static void Main(string[] args)
		{
			// Create a golden sword and name it
			Sword goldSword = new Sword("Golden Sword");

			goldSword.Equip();
			goldSword.TakeDamage(20);
			goldSword.Sell();

			Console.WriteLine("\n------------------------\n");

			// Create a steal sword and name it
			Sword steelSword = new Sword("Steel Sword");
			steelSword.Equip();
			steelSword.Sell();

			Console.WriteLine("\n------------------------\n");

			// Create an Axe
			Axe axeOfAwesome = new Axe("Axe of Awesome");
			axeOfAwesome.Equip();
			axeOfAwesome.TakeDamage(10);
			axeOfAwesome.Sell();


			// Create an Inventory
			Console.WriteLine("\n\n------------INVENTORY------------\n");

			IItem[] inventory = new IItem[3];
			inventory[0] = goldSword;
			inventory[1] = axeOfAwesome;
			inventory[2] = steelSword;

			// Loop through and turn in all eligible quest items
			for (int i = 0; i < inventory.Length; i++)
			{
				// Store the quest item as an IPartOfQuest if it is possible, if it isn't, it will be null
				IPartOfQuest questItem = inventory[i] as IPartOfQuest;

				if (questItem != null)
				{
					questItem.TurnIn();
				}
				else
				{
					Console.WriteLine("Not turned in because item isn't a quest item.");
				}
			}
		}
	}
}
