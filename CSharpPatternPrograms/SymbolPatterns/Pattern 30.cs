using System;

class Pattern_116
{
    public static void Main(string[] args)
    {
        int i, j, c, k;

        /*  logic one using 3 loops
        for(i=4;i>=0;i-=2)
        {
        for(c=2;c>0;c--)
        {
        for(j=6;j>i;j--)
        {
        System.out.print("*");
        }
        System.out.println();
        }
        } */

//logic two using if-else
        for (i = 1; i <= 6; i++)
        {
            /*if(i%2!=0)
            {
            k=i+1;
            }else
            {
            k=i;
            }*/

            k = (i % 2 != 0)?i + 1:i; //conditional operator

            for (j = 0; j < k; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
