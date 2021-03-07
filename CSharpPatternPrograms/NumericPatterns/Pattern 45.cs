using System;

public class Pattern_133
{

    public static void Main(string[] agrs)
    {
        int i;
        int j;
        int n1 = 0;
        int n2 = 1;
        int r = n1 + n2;


        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= i; j++)
            {

                Console.Write("{0:D} ", r);
                r = n1 + n2;
                n1 = n2;
                n2 = r;
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    }
}
