/*
If a sequence of values follows a pattern of adding a fixed 
amount from one term to the next, it is referred to as an  
arithmetic sequence.
The number added to each term is constant is called as the 
common difference, d.

e.g.

1, 4, 7, 10, 13, 16, ...

An arithmetic sequence starts with term(a) 1 and having 
                                        common difference (d)
                                        of 3.

*/

//import java.util.Scanner; - user input

class ArithmeticSequence 
{
 public static void main(String args[])
 {
  int n=5; // limit
  int d=3; //common difference
  int a=2; // terms
   
  /*
 (If you want to take input from user, you may use this code)
             
  Scanner sc=new Scanner(System.in);
      
  System.out.print("Enter A (first term) : ");        
  a= sc.nextInt();
      
  System.out.print("Enter N (limit) : ");        
  n= sc.nextInt();
      
  System.out.print("Enter D (common difference) : ");        
  d= sc.nextInt();
  */    
  
  for(int i=1;i<=n;i++)
  {
   System.out.print("  "+a);    
   a=a+d; // adding diff. with term
  }
  
  
 }// end of main()
}// end of class

/*
 OUTPUT :
 
 2  5  8  11  14

 */