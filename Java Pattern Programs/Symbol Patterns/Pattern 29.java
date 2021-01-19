 class Pattern_115
 {
     public static void main(String args[])
     {
 int z=1;
 int n=5; //size
 
 for(int i=0;i<n;i++){
 for(int j=n-1;j>i;j--)
 {
 System.out.print(" ");
 }
 for(int k=0;k<n;k++)
 {
 System.out.print("*");
 }
 z++;
 System.out.println();
 }
     } //end of main
 }  //end of class