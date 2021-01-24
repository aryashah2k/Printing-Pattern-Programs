using System;

/*
 The sequence which is generated from a pattern of dots which form a triangle is known as Triangular Number Sequence.
 */

class TriangularNumbersSeries
{
    public static void Main(string[] agrs)
    {
        int n = 5; //size

        for (int i = 1; i <= n; i++)
        {
            int num = (i * (i + 1)) / 2;
            Console.Write(" " + num);
        }
        Console.ReadKey(true);
    }
}

/*
 OUTPUT :

 1 3 6 10 15

  **/
