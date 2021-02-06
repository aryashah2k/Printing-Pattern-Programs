using System;

   class Pattern_34
 {
     public static void Main(string[] args)
     {
 int min_stars = 1; /*change value to set min. no. of stars in piramid
             take odd no. for odd no. of stars in each row 1-3-5 etc
             take even no. for even no. stars in each row, 2-4-6 etc */

 int p_height = 5; //change  value to increase or decrease the size of piramid

 int p_space = p_height - 1;

 for (int i = 0;i < p_height;i++)
 {
 for (int j = p_space;j > i;j--)
 {
 Console.Write(" ");
 }
 for (int k = 0;k < min_stars;k++)
 {
 Console.Write("*");
 }
 min_stars += 2;
 Console.WriteLine();
 }
  Console.ReadKey(true);
    } //end of main
 } //end of class


