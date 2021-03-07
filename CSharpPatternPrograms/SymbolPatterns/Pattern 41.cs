using System;

class Pattern_127
 {
  public static void Main()
   {
    int n = 7; // size

    for (int i = 1; i <= n; i++)
     {
      for (int j = 1; j <= n; j++)
       {
        if (j == 1 || i == j || i == n)
         {
          Console.Write("*");
         }
        else
         {
          Console.Write(" ");
         }
       }

     Console.WriteLine();
     }
     Console.ReadKey(true);
   }
 }
