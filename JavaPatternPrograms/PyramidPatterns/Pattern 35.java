 class Pattern_124
 {
     public static void main(String args[])
     {
 int n=3;  //size
 int z=1;
  
 for(int i=0;i<n;i++){
 for(int j=2;j>0;j--)
 {
 for(int x=n-1;x>i;x--)
 {
 System.out.print(" ");
 }
 for(int y=0;y<z;y++)
 {
 System.out.print("*");
 }
 System.out.println();
 }
 z+=2;
 }
     } //end of main
 }  //end of class