class Pattern_142
 {
     public static void main(String args[])
     {
 for(int i=1;i<=15;i++){
 for(int j=1;j<=10;j++)
 {
 if( ( (i>=4 && i<=6) && (j>=4) ) || ( (i>=10 && i<=12) && (
     j<=7) ) )
 {
 System.out.print(" ");
 }else
 {
 System.out.print("*");
 }
 }
 
 System.out.println();
 }
 
 