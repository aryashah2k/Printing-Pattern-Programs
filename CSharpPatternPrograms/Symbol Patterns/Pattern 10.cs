using System;

 public class Pattern_64
 {
     public static void Main(string[] a)
     {

     int p_height = 5;

     for (int i = 1; i <= p_height; i++)
     {
      for (int k = p_height - 1; k >= i; k--)
      {
       Console.Write(" ");
      }
      for (int j = 1; j <= i; j++)
      {
       Console.Write("* ");//space after *
      }
       Console.WriteLine();
     }
     Console.ReadKey(true);
    }
 }

/*-- Another Logic using if-else -

class Pattern_64
{
public static void Main()
{
 int n = 5; //size

 for (int i = 1;i <= n;i++)
 {
  for (int j = n;j >= 1;j--)
  {
   if (i >= j)
   {
   Console.Write("* "); //space after *
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
