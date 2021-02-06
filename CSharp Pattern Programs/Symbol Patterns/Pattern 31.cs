using System;

class Pattern_117
{
    public static void Main(string[] args)
    {
        int i, j, c, k;

        /*   using loops only

        for(i=4;i>=0;i-=2)
        {
        for(c=2;c>0;c--)
        {
        for(int g=0;g<i;g++)
        {
        System.out.print(" ");
        }
        for(j=6;j>i;j--)
        {
        System.out.print("*");
        }
        System.out.println();
        }
        }
        */

// using if-else

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

            for (int g = 6; g > k; g--)
            {
                Console.Write(" ");
            }
            for (j = 0; j < k; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class
