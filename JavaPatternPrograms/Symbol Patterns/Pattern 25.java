 class Pattern_111
 {
     public static void main(String args[])
     {
 int n=5; //size
 for(int i=1;i<=n;i++){
 for(int j=1;j<=n;j++)
 {
 if(i==j||i+j==n+1)
 System.out.print("x"); //ANY SYMBOL
 else
 System.out.print("o"); //ANY SYMBOL
 }
 System.out.println();
 }
     } //end of main
 }  //end of class