class Pattern_145
{
   /This is for printing odd no. of stars/

    public static void main (String args[])
    {

    int n = 3; // size

    int s1 = n * 2 - 1; // stars count
    int s2 = 3;
    /*
    s1 for top part
    s2 for bottom part
    */

    int i;
    int j;
    int k;

   /* top part*/

     for (i = 1;i <= n;i++)
     {
      for (j = 1;j < i;j++)
      {
      System.out.print("  ");
      }
      for (k = 1;k <= s1;k++)
      {
       System.out.print("*");
      }
      s1 -= 2;
      System.out.println();
     }

   /bottom part/

     for (i = 1;i <= n - 1;i++)
     {
      for (j = n - 2;j >= i;j--)
      {
      System.out.print("  ");
      }
      for (k = 1;k <= s2;k++)
      {
      System.out.print("*");
      }
      s2 += 2;
      System.out.println();
     }
     
    }
}