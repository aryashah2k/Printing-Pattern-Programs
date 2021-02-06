using System;

public class BarChart1
{
    public static void Main(string[] args)
    {
        int n;
        int[] numArr = new int[20];
        int max = 0;
        int i;
        int j;

        Console.Write("Enter total number of entities : ");
        n = Convert.ToInt32(Console.ReadLine());

        for (i = 0; i < n; i++)
        {
            Console.Write("Enter value for entity [" + (i + 1) + "] : ");
            numArr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\n  BAR CHART \n\n");


        for (i = 0; i < n; i++)
        {
            if (numArr[i] > max)
            {
                max = numArr[i];
            }
        }


        for (i = 0; i < max; i++)
        {
            for (j = 0; j < n; j++)
            {
                if (numArr[j] >= max - i)
                {
                    Console.Write(" #  ");
                }
                else
                {
                    Console.Write("    ");
                }
            }

            Console.WriteLine("");
        }
        Console.WriteLine("");
        for (i = 0; i < n; i++)
        {
            Console.Write(" " + (i + 1) + "  ");
        }
        Console.ReadKey(true);
    }
}
