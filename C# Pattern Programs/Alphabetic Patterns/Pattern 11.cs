using System;

class Pattern_27
{
   public static void Main()
   {
    int n = 5; // size

      for (int i = 0;i < n;i++)
      {
      for (int j = n - 1;j > i;j--)
      {
      Console.Write(" ");
      }
      for (int k = 0;k <= i;k++)
      {
      Console.Write((char)(i + 65));
      }

      Console.WriteLine();
      }
        Console.ReadKey(true);
    }
}
