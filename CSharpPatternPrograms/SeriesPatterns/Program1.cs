using System;

/*
If a sequence of values follows a pattern of adding a fixed amount from one term to the next, it is referred to as an  arithmetic sequence.
The number added to each term is constant is called as the common difference, d.

e.g.

1, 4, 7, 10, 13, 16, ...

An arithmetic sequence starts with term(a) 1 and having common difference (d) of 3.

*/

class ArithmeticSequence
{
    public static void Main(string[] args)
    {
        int n = 5; // limit
        int d = 3; //common difference
        int a = 2; // terms

        /*
        (If you want to take input from user, you may use this code)

        Console.WriteLine("Enter A (first term) : ");
        a= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter N (limit) : ");
        n= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter D (common difference) : ");
        d= Convert.ToInt32(Console.ReadLine());
        */

        for (int i = 1; i <= n; i++)
        {
            Console.Write("  " + a);
            a = a + d; // adding diff. with term
        }
        Console.ReadKey(true);

    } // end of main()
} // end of class

/*
 OUTPUT :

 2  5  8  11  14

 */
