using System;

   class Pattern_69
 {
     public static void Main(string[] a)
     {
     int p_height = 5;

     for (int i = p_height; i >= 1; i--)
     {
      for (int k = p_height - 1; k >= i; k--)
      {
      Console.Write(" ");
      }
      for (int j = i; j >= 1; j--)
      {
      Console.Write("* ");// space after *
      }
     Console.WriteLine();
     }
      Console.ReadKey(true);
    }
 }

/*-- Another Logic using if-else --
class Pattern_69
{

public static void Main()
{
 int n = 5; //size

 for (int i = n;i >= 1;i--)
 {
  for (int j = n;j >= 1;j--)
  {
   if (i >= j)
   {
   Console.Write("* "); // space after *
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
/--------------------------------/
