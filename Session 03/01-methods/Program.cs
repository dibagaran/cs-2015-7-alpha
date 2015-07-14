using System;

class Program
{
	static void Main ()
	{
		var ever = true; // Variable Purpose: Code Clarity and Readability

		for (; ever;) {
			ClearScreen ();
			DisplayMenu ();
			string userChoice = GetUserInput ();
			Process (userChoice);
			WaitForAKeyPressToDoItAllOverAgain ();
		}
	}

	static void DisplayMenu () // Method Purpose: Modularization
	{
		var menu = new string[]{ "File", "Edit", "View", "Tools", "Help", "Exit" };

		for (int index = 1; index <= menu.Length; index++)
			Print (index + ". " + menu [index - 1]);
	}

	static void Process (string choice) // Method Purpose: Modularization
	{
		switch (choice) {
		case "1":
			Print ("'File' selected.");
			break;
		case "2":
			Print ("'Edit' selected.");
			break;
		case "3":
			Print ("'View' selected.");
			break;
		case "4":
			Print ("'Tools' selected.");
			break;
		case "5":
			Print ("'Help' selected.");
			break;
		case "6":
			Environment.Exit (0);
			break;
		default:
			Print ("Invalid choice.");
			break;
		}
	}

	static void ClearScreen () // Method Purpose: Code Clarity and Readability
	{
		Console.Clear ();
	}

	static string GetUserInput () // Method Purpose: Code Clarity and Readability
	{
		return Console.ReadLine ();
	}

	static void Print (string output) // Method Purpose: Code Clarity and Readability
	{
		Console.WriteLine (output);
	}

	static void WaitForAKeyPressToDoItAllOverAgain () // Method Purpose: Code Clarity and Readability
	{
		Console.ReadKey (true);
	}
}
