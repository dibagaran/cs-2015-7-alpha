using System;

namespace Project
{
    class Program
    {
        public static void Main (string[] args)
        {
            var desktop = new ConsoleDesktop ();

            var leandow = new Leandow ("Terminal", 50, 20, 4, 2);
            //TODO: Try this code instead and handle the problem: var leandow = new Leandow ("Terminal", 50, 20, 30, 30);

            desktop.Add (leandow);

            // Or: new ConsoleDesktop ().Show (new Leandow("Terminal", 40, 20));
        }
    }
}
