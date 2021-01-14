class FibonacciNumbersSeries
{
 public static void main(String agrs[])
 {
  int n=15;//size or upper limit
  int a=0; 
  int b=1; 
  int c=a+b;
  
  while(c<=n)
  {
  System.out.print(" "+c);
  c=a+b;
  a=b;
  b=c;
  }
 }
}

/*
 OUTPUT :

 1 1 2 3 5 8 13
 
 **/