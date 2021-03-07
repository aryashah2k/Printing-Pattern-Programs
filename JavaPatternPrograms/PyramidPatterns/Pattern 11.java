 class Pattern_44
 {
     public static void main(String args[])
     {
     int n = 5; //size;
     int z = 1;
     int l = 1;
     int i;
     int j;
     int k;
      
     for (i = 0;i < 5;i++)
     {
     for (j = 4;j > i;j--)
     {
     System.out.print(" ");
     }
     for (k = 1;k <= z;k++)
     {
     System.out.print((char)(Math.abs(k - l) + 65));
     }
     l++;
     z += 2;
     System.out.print("\n");
     }
      
     }
 }