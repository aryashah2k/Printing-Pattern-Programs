using System;

class X_Mas_Tree
{
   public static void Main()
    {
      int i; // loop var.
      int j;
      int k;

      int height = 3; // height and width you may change it
      int width = 4;

      int space = width * 5; // space from the left corner

      int r = 1; // loop var. runs
      int m = 1; // used to print x-mas tree *

   /* tree's upper part - leaves */

   for (r = 1;r <= height;r++)
   {
     for (i = m;i <= width ;i++)
     {
      for (j = space;j >= i ;j--)
      {
      Console.Write(" ");
      }
     for (k = 1;k <= i ;k++)
     {
      Console.Write("* ");
     }
        Console.WriteLine();
     }

    m += 2;
    width += 2;
   } // end of upper part

   /* tree's lower part - stem*/

     for (i = 1;i <= 4;i++)
     {
      for (j = space-3;j >= 1 ;j--)
      {
      Console.Write(" ");
      }
     for (k = 1;k <= 4 ;k++)
     {
      Console.Write("* ");
     }
        Console.WriteLine();
     }
             Console.ReadKey(true);
   }
}
