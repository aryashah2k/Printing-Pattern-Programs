/*
 * In this program, we print the series of prime numbers up 
 to 'n'.
 * First we check each number (1 to n) for prime number.
 * If the number is prime we print it.
 * 
 **/

class PrimeNumbersSeries
{
 public static void main(String agrs[])
 {
  int n=10;//size
  int num=1,count=0;
  
  
  while(num<=n)
  {
    for(int i=1;i<=num;i++)
  {
      if(num%i==0)
      { count++; }
  }
    if(count==2) // true if number is prime
    {
     System.out.print(" "+num);
    }
    
    count=0;  // reset count
    
    num++; // for checking next num
  }
  
 }
}

/*
 OUTPUT :
 
 2 3 5 7
 
 **/