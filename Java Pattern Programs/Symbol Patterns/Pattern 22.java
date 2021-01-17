 class Pattern_102
 {
     public static void main(String args[])
     {
 int n=5; //size
 
 for(int i=1;i<=n;i++){
 for(int j=1;j<=n;j++)
 {
 if(i==j||i+j==n+1)
 System.out.print("*"); 
 else
 System.out.print(" "); 
 }
 System.out.println();
 }
     } //end of main
 }  //end of class