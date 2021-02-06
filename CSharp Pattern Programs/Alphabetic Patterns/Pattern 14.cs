using System;

class Pattern_33
{
    public static void Main()
    {
     int n = 5; // size

     for (int i = n - 1;i >= 0;i--)
     {
      for (int j = n - 1;j > i;j--)
      {
      Console.Write(" ");
      }
      for (int k = 0;k <= i;k++)
      {
      Console.Write((char)(k + 65));
      }
      Console.WriteLine();
     }

        Console.ReadKey(true);
    }
}
