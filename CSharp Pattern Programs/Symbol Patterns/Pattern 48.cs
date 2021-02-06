using System;

class Pattern_142
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 15; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                if (((i >= 4 && i <= 6) && (j >= 4)) || ((i >= 10 && i <= 12) && (j <= 7)))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();
        }

        // Or may be written as :
        /*
        for(int i=1;i<=15;i++){
        for(int j=1;j<=10;j++)
        {
        if((i>=4 && i<=6) && (j>=4))
        {
        System.out.print(" ");
        }else if( (i>=10 && i<=12) && (j<=7) )
        {
        System.out.print(" ");
        }else
        {
        System.out.print("*");
        }
        }
        System.out.println();
        }
        */

        Console.ReadKey(true);
    } //end of main
} //end of class
