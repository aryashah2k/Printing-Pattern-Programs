using System;

class Pattern_226
{
    public static void Main()
    {
        string str = "PATTERN";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(str[j]);
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
