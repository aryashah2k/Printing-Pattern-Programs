using System;

class Pattern_227
{
    public static void Main()
    {
        string str = "ABCDE";
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str.Length; j++)
            {
                if (i == 2)
                {
                    Console.Write(str[j]);
                }
                else if (j == 2)
                {
                    Console.Write(str[i]);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
