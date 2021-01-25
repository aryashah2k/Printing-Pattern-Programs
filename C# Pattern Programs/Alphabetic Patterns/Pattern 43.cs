using System;

/*
 * C
 * CS
 * CSh
 * CSha
 * CShar
 * CSharp
 * CShar
 * CSha
 * CSh
 * CS
 * C
 *
 **/

class Pattern_140
{
    public static void Main(string[] a)
    {
        int c, d;
        string str = "CSharp"; //put any string

        int stlen = str.Length;


        Console.Write("\n\n");

        for (c = 0; c < stlen; c++)
        {
            d = c + 1;
            Console.WriteLine(str.Substring(0, d));
        }

        for (c = stlen - 2; c >= 0; c--)
        {
            d = c + 1;
            Console.WriteLine(str.Substring(0, d));
        }
        Console.ReadKey(true);
    }
}
