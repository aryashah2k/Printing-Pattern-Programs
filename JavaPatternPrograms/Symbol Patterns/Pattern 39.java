 class Pattern_125
 {
     public static void main(String args[])
     {
 int n=5; //size
 for(int i=1;i<=n;i++){
 for(int j=1;j<=n;j++)
 {
 if((j==1||j==n)||(i==1||i==n))
 System.out.print("*");
 else
 System.out.print(" ");
 }
 System.out.println();
 }
     } //end of main
 }  //end of class