 class Pattern_74
 {
     public static void main(String args[])
     {
     int i;
     int j;
     int k;
      
     for (i = 4; i >= 0; i--)
     {
      for (k = 3; k >= i; k--)
      {
       System.out.print(" ");
      }
      for (j = i; j >= 0; j--)
      {
       System.out.print((char)((i - j) + 65));
       System.out.print(" ");
      }
      System.out.print("\n");
     }
       
     }
 }