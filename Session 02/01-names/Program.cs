using System;

class Program
{
	public static void Main (string[] args)
	{
		string[] names = new string[100];
		int current = 0;

		while (true) {
			Console.Clear ();
			Console.WriteLine ("1. Add a new name");
			Console.WriteLine ("2. List all names");
			Console.WriteLine ("3. Exit");
			string choice = Console.ReadLine ();
			switch (choice) {
			case "1":
				if (current < names.Length) {
					Console.WriteLine ("Please enter a new name: ");
					string name = Console.ReadLine ();
					names [current++] = name;
					Console.WriteLine (name + " added successfully.");
				} else
					Console.WriteLine ("Program memory is full.");
				break;
			case "2":
				if (current == 0)
					Console.WriteLine ("Program memory is empty.");
				else {
					Console.WriteLine ("=== NAME ===");
					for (int i = 0; i < current; i++) {
						Console.WriteLine (names [i]);
					}
				}
				break;
			case "3":
				Environment.Exit (0);
				break;
			default:
				break;
			}
			Console.ReadLine ();
		}
	}
}
