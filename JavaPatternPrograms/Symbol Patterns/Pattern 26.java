 class Pattern_112
 {
     public static void main(String args[])
     {
 int n=5; //size
 int m=(n/2)+1;   //center
 for(int i=1;i<=n;i++){
 for(int j=1;j<=n;j++)
 {
 if(i==m&&j==m)
 System.out.print("o"); 
 else
 System.out.print("x"); 
 }
 System.out.println();
 }
     } //end of main
 }  //end of class