 class Pattern_118
 {
     public static void main(String args[])
     {
 int n=6;  //size
 int i,j,c,k;
  
 
 /*
 // logic one (using 3 Loops)
 
 for(i=n;i>0;i-=2)
 {
 for(c=2;c>0;c--)
 {
 for(j=0;j<i;j++)
 {
 System.out.print("*");
 }
 System.out.println();
 }
 }


 */
 
 // logic two (using if-else)
 for(i=n;i>0;i--)
 {
 
 //if(i%2!=0) { k=i+1; } else { k=i; }
 
 k=(i%2!=0)?i+1:i;  //use of conditional operator instead of 
   if-else
 
 for(j=0;j<k;j++)
 {
 System.out.print("*");
 }
 System.out.println();
 }
     } //end of main
 }  //end of class