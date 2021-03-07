 public class Pattern_132
 {
     public static void main(String args[])
     {
      int i;
      int j;
 
      int n = 8; //size (even)
 
      int c1 = (n - 1) / 2; //cond
 
      int c2 = 3 * n / 2 - 1; //cond
 
      for (i = 0;i < n;i++)
      {
       for (j = 0;j < n;j++)
       {
         if (i + j <= c1  || i - j >= c1  || j - i >= c1  || i + j 
       >= c2)
         {
          System.out.print("* ");
         }
         else
         {
          System.out.print("  ");
         }
       }
       System.out.println("");
      }
     }
 }