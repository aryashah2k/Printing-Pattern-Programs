using System;

class Pattern_229
{
    public static void Main()
    {
        int n = 6; //size
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i % 2 == 0) // for even rows
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write("o");
                    }
                }
                else // for odd rows
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("o");
                    }
                    else
                    {
                        Console.Write("x");
                    }
                }
            }
            Console.WriteLine("");
        }
        Console.ReadKey(true);
    }
}
