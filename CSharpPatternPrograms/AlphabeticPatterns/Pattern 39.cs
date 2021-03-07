using System;

class Pattern_94
 {
  public static void Main()
   {
    int n = 9; // size
    int px = n / 2 + 1; // print controls
    int p = 0; // print char

    for (int i = 1; i <= n; i++)
     {
      for (int j = 1; j <= n; j++)
       {
        if (j == px || j == n - px + 1)
         {
          Console.Write((char)(p + 65));
         }
        else
         {
          Console.Write(" ");
         }
       }

     if (i <= n / 2)
      {
       px--;
       p++;
      }
     else
      {
       px++;
       p--;
      }
     Console.WriteLine();
     }
     Console.ReadKey(true);
   }
 }
