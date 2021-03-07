using System;

class Pattern_23
{
    public static void Main()
    {

    for (int i = 0;i <= 4;i++)
    {
    for (int j = 4;j >= i;j--)
    {
    Console.Write((char)(j + 65));
    }
    Console.WriteLine();
    }
        Console.ReadKey(true);
    }
}
