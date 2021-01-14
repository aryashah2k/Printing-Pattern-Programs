 class Wave_23
 {
     public static void main(String args[])
     {
 
     int wave_height = 4; //change  value to increase or 
                    decrease the height of wave
     int wave_length = 4; //change  value to increase or 
                    decrease the length of wave
 
     int i;
     int j;
     int k;
     int num = wave_height + 1;
     int jump = (num * 3 + 2) - (num + 3);
     int inc = 1;
     int x = 0;
      
 
     for (i = 1;i <= wave_height;i++)
     {
     for (j = 1;j <= wave_length;j++)
     {
     if (i != wave_height)
     {
     System.out.print("   ");
     }
     else
     {
     System.out.printf("%02d ", (num - 1));
     }
 
     for (k = 1;k <= 4;k++)
     {
     if (i == 1 || k == 1 || k == 4)
     {
     System.out.printf("%02d ", (num));
     num = num + inc;
     }
     else
     {
     System.out.print("   ");
     }
 
 
     }
     num = num - inc; //restore value of n (false increment)
 
 
 
 
     if (i != wave_height)
     {
     System.out.print("   ");
     }
     else
     {
     System.out.printf("%02d ", (num + 1));
     }
 
     num += jump;
 
     }
 
     jump -= 2;
     inc = 5 + x;
     x += 2;
 
     num = wave_height - i + 1;
 
     System.out.print("\n");
     }
      
     }
 }