using System;

class Program
{
    static void Main ()
    {
        // Value Type
        int i = 0;
        Method1 (i);
        Console.WriteLine (i);
        Method2 (ref i);
        Console.WriteLine (i);
        Method3 (out i);
        Console.WriteLine (i);

        // Reference Type
        int[] j = { 0, 2, 4, 6, 8 };
        Method4 (j);
        Console.WriteLine (j [0]);
        int[] k = j;
        k[0] = 1000;
        Console.WriteLine (j [0]);
    }

    static void Method1 (int a)
    {
        a++;
    }

    static void Method2 (ref int a)
    {
        a++;
    }

    static void Method3 (out int a)
    {
        a = 1000;
    }

    static void Method4 (int[] a)
    {
        a[0]++;
    }
}
