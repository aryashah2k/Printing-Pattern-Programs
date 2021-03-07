using System;
class Pattern_152
{
  public static void Main()
   {
     int n = 5; //size
     int i;
     int j;

      for (i = n;i >= 1;i--)
    {
      for (j = 1;j <= i;j++)
      {
      if (i % 2 != 0)
      {
      Console.Write((char)(i + 64));
      }
      else
      {
      Console.Write(i);
      }
      }
     Console.WriteLine();
    }
          Console.ReadKey(true);
   }
}
