using System;

class Pattern_146
{
    public static void Main()
     {
       int i;
       int j;
       int k;

       int d1 = 1; // for printing

       int n = 4; //size

       int d2 = (n * n) + 1;
        /* for 2nd part */

        for (i = n;i >= 1;i--)
    {
     
   for (k = 1;k <= i;k++)
     {
      Console.Write(d2+" ");
      d2++;
     }
     d2--; // decrement to get last printed value

     d2 = d2 - ((i - 1) * 2); // used to set next print value

     Console.WriteLine();
    }
          Console.ReadKey(true);
   }
}
