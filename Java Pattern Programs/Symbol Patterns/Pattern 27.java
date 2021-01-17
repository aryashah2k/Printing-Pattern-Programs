 class Pattern_113
 {
     public static void main(String a[])
     {
     
     for (int i = 1; i <= 5; i++)
     {
      for (int j = 1;j <= 5;j++)
      {
       if (j == 3 || i == 3)
       {
        System.out.print("* ");
       }
       else
       {
        System.out.print("  ");
       }
      }
      System.out.print("\n");
     }
     
     }
 }