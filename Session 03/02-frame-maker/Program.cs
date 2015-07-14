using System;

class Program
{
	static void Main ()
	{

		/* Excercise:
			1. Try to optimize and reduce lines of code in this program.
			2. Enable shadow direction (Right-Bottom, Right-Top, Left-Bottom, Left-Top) */

		int frameWidth = GetInt32 ("Frame Width");
		int frameHeight = GetInt32 ("Frame Height");
		int frameOffset = GetInt32 ("Frame Offset");

		bool shadowIsEnabled = GetString ("Enable shadow? (y/n): ") == "y";

		Console.WriteLine ();

		for (int row = 1; row <= frameHeight; row++) {
			for (int column = 1; column <= frameOffset; column++)
				Console.Write (" ");

			for (int column = 1; column <= frameWidth; column++)
				Console.Write (row == 1 || row == frameHeight ? "█" : column == 1 || column == frameWidth ? "█" : " ");

			if (shadowIsEnabled && row > 1)
				Console.Write ("░");

			Console.WriteLine ();
		}

		if (shadowIsEnabled) {
			for (int column = 1; column <= frameOffset + 1; column++)
				Console.Write (" ");

			for (int column = 1; column <= frameWidth; column++)
				Console.Write ("░");

			Console.WriteLine ();
		}
	}

	static string GetString (string message)
	{
		Console.Write (message);
		return Console.ReadLine ();
	}

	static int GetInt32 (string parameter)
	{
		Console.Write ("Please enter '" + parameter + "': ");
		string inputAsString = Console.ReadLine ();
		int inputAs32BitInteger = Convert.ToInt32 (inputAsString);
		return inputAs32BitInteger;
	}
}
