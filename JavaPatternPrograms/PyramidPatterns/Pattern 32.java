 class Pattern_99
 {
     public static void main(String args[])
     {
     int min_stars = 1; /*change value to set min. no. of stars 
                  in piramid
                  take odd no. for odd no. of stars in each row 1-3-5 
                  etc
                  take even no. for even no. stars in each row, 2-4-6 
                  etc */
 
     int p_height = 5; //change  value to increase or decrease 
                 the size of piramid
 
 
     int p_space = p_height - 1;
 
     int i;
     int j;
     int k;
     int n;
     int x = 1;
      
     for (i = 0;i < p_height;i++)
     {
     for (j = p_space;j > i;j--)
     {
     System.out.print(" ");
     }
     for (k = 0;k < min_stars;k++)
     {
     System.out.print("*");
     }
 
 
     for (n = (p_height + p_height - 2);n >= x;n--)
     {
     System.out.print(" ");
     }
     for (k = 0;k < min_stars;k++)
     {
     System.out.print("*");
     }
 
 
     min_stars += 2;
     x += 2;
     System.out.print("\n");
     }
      
     }
 }