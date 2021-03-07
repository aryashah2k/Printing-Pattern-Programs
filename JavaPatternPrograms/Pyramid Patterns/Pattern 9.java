 class Pattern_42
 {
     public static void main(String args[])
     {
     int n = 5; //size
     int z = 0;
     int i;
     int j;
     int k;
      
     for (i = 0;i < n;i++)
     {
     for (j = n - 1;j > i;j--)
     {
     System.out.print(" ");
     }
     for (k = 0;k <= z;k++)
     {
     System.out.print((char)(z - k + 65));
     }
     z += 2;
     System.out.print("\n");
     }
      
     }
 }