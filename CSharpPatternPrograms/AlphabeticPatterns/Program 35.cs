using System;

class Pattern_84
 {
  public static void Main()
   {
    int n = 5; // size
    int px = n; // print controls
    int py = n;

    for (int i = 1; i <= n; i++)
     {
      for (int j = 1; j <= n * 2; j++)
       {
        if (j == px || j == py)
         {
          Console.Write((char)(i + 64));
         }
        else
         {
           Console.Write(" ");
         }
       }

     px--;
     py++;

     Console.WriteLine();
     }
     Console.ReadKey(true);
   }
 }
