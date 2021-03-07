using System;

class Pattern_47
{
    public static void Main(string[] args)
    {
        int p_height = 4; //change value to increase or decrease the size of piramid

        int max_stars = p_height * 2 - 1;

        int p_space = p_height - 1;

        for (int i = p_height; i >= 1; i--)
        {
            for (int j = p_space; j >= i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= max_stars; k++)
            {
                Console.Write("*");
            }
            max_stars -= 2;
            Console.WriteLine();
        }
        Console.ReadKey(true);
    } //end of main
} //end of class

/*-- Another Logic using if-else -

using System;

class Pattern_47
 {
  public static void Main()
   {
    int n = 5; // size
    int px = 1; // print controls
    int py = n * 2 - 1;

    for (int i = 1; i <= n; i++)
     {
      for (int j = 1; j < n * 2; j++)
       {
        if (j >= px && j <= py)
         {
          Console.Write("*");
         }
        else
         {
          Console.Write(" ");
         }
       }
     px++;
     py--;

     Console.WriteLine();
     }
     Console.ReadKey(true);
   }
 }
 /--------------------------------/



