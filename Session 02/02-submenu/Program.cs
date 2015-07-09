using System;

class Program
{
	public static void Main (string[] args)
	{

		//Excercise: Try to optimize and reduce lines of code in this program

		string choice;
		for (;;) {

			Console.Clear ();
			Console.WriteLine ("=== MAIN MENU ===");
			Console.WriteLine ("1. FILE");
			Console.WriteLine ("2. EDIT");
			Console.WriteLine ("3. HELP");
			Console.WriteLine ("-----------------");
			Console.WriteLine ("4. EXIT");

			switch (Console.ReadLine ()) {
			case "1":
				for (;;) {

					Console.Clear ();
					Console.WriteLine ("==== FILE ====");
					Console.WriteLine ("1. NEW");
					Console.WriteLine ("2. SAVE");
					Console.WriteLine ("3. SAVE AS ...");
					Console.WriteLine ("--------------");
					Console.WriteLine ("4. BACK");

					choice = Console.ReadLine ();

					if (choice == "4")
						break;
					else {
						switch (choice) {
						case "1":
							Console.WriteLine ("'NEW' MENU ITEM SELECTED.");
							break;
						case "2":
							Console.WriteLine ("'SAVE' MENU ITEM SELECTED.");
							break;
						case "3":
							Console.WriteLine ("'SAVE AS ...' MENU ITEM SELECTED.");
							break;
						default:
							Console.WriteLine ("INVALID CHOICE.");
							break;
						}
						Console.ReadLine ();
					}
				}
				break;
			case "2":
				for (;;) {

					Console.Clear ();
					Console.WriteLine ("=== EDIT ===");
					Console.WriteLine ("1. CUT");
					Console.WriteLine ("2. COPY");
					Console.WriteLine ("3. PASTE");
					Console.WriteLine ("------------");
					Console.WriteLine ("4. BACK");

					choice = Console.ReadLine ();

					if (choice == "4")
						break;
					else {
						switch (choice) {
						case "1":
							Console.WriteLine ("'CUT' MENU ITEM SELECTED.");
							break;
						case "2":
							Console.WriteLine ("'COPY' MENU ITEM SELECTED.");
							break;
						case "3":
							Console.WriteLine ("'PASTE' MENU ITEM SELECTED.");
							break;
						default:
							Console.WriteLine ("INVALID CHOICE.");
							break;
						}
						Console.ReadLine ();
					}
				}
				break;
			case "3":
				for (;;) {

					Console.Clear ();
					Console.WriteLine ("=== HELP ===");
					Console.WriteLine ("1. ABOUT");
					Console.WriteLine ("------------");
					Console.WriteLine ("2. BACK");

					choice = Console.ReadLine ();

					if (choice == "2")
						break;
					else {
						switch (choice) {
						case "1":
							Console.WriteLine ("'ABOUT' MENU ITEM SELECTED.");
							break;
						default:
							Console.WriteLine ("INVALID CHOICE.");
							break;
						}
						Console.ReadLine ();
					}
				}
				break;
			case "4":
				Environment.Exit (0);
				break;
			default:
				Console.WriteLine ("INVALID CHOICE.");
				break;
			}
		}
	}
}
