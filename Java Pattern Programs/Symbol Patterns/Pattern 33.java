class Pattern_119
 {
     public static void main(String args[])
     {
 int n=6;  //size
 int k;
  
 
 
 // logic one (using Loops only)
 /*
 for(int i=n;i>0;i-=2)
 {
 for(int c=2;c>0;c--)
 {
 for(int x=i;x<n;x++)
 {
 System.out.print(" ");
 }
 
 for(int j=0;j<i;j++)
 {
 System.out.print("*");
 }
 System.out.println();
 }
 }
