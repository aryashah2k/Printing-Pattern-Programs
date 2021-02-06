using System;

class Pattern_225
{
    public static void Main()
    {
        string str = "PATTERN";
        for (int i = 0; i < str.Length; i++)
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
