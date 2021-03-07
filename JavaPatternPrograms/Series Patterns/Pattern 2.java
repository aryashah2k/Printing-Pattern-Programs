/*
If a sequence of values follows a pattern of multiplying a 
fixed amount times each term to arrive at the following term,
it is referred to as a  geometric sequence.
The number multiplied each time is constant and  is called 
as the common ratio, r.
e.g.

 2, 6, 18, 54, ...

An geometric sequence starts with term(a) 2 and having 
                                       common ratio (r) of 3.

*/

// import java.util.Scanner; - user input

class GeometricSequence 
{
 public static void main(String args[])
 {
  int n=5; // limit
  int r=2; //common ratio
  int a=5; // terms
  int sum=0; // sum of the series
              
  /*
 (If you want to take input from user, you may use this code)
  
  Scanner sc=new Scanner(System.in);
      
  System.out.print("Enter A (first term) : ");        
  a= sc.nextInt();
      
  System.out.print("Enter N (limit) : ");        
  n= sc.nextInt();
      
  System.out.print("Enter R (common ratio) : ");        
  r= sc.nextInt();
  */    
  
  for(int i=1;i<=n;i++)
  {
   System.out.print("  "+a);    
   a=a*r; // multiplying diff. with term
  }
  
  
 }// end of main()
}// end of class

/*
 OUTPUT :
 
  5  10  20  40  80
 */