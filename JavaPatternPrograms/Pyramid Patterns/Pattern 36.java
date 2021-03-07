 public class Pattern_139
 {
     public static void main(String args[])
     {
     int i;
     int j;
     int k = 1;
     int n = 3; //size
     int x = 1;
     int z;
     int g;
 
     for (i = 0;i < n;i++)
     {
 
     for (z = n - 1;z >= i;z--)
     {
       System.out.print("  ");
     }
 
     for (j = 0;j < k;j++)
     {
      if (i == j)
      {
       g = (x + 1) * (j + j);
       g = (g == 0)?1:g;
       System.out.print(" "+g);
       continue;
      }
       x += 2;
       System.out.print(" "+x);
       }
      k += 2;
      System.out.println("");
     }
 
     }
 }