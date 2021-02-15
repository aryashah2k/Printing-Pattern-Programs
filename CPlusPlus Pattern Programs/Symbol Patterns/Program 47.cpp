#include<iostream>
using namespace std;
int main()
{
   int pyramid_height;
   cout<<"Enter Pyramid Height:"<<endl;
   cin>>pyramid_height;
   int max_star=pyramid_height*2-1;
   int pyramid_space=pyramid_height-1;
   for(int i=pyramid_height;i>=1;i--)
   {
       for(int j=pyramid_space;j>=i;j--)
       {
           cout<<" ";
       }
       for(int k=1;k<=max_star;k++)
       {
           cout<<"*";
       }
       max_star-=2;
       cout<<endl;
   }
}

// Alternative Way:

#include<iostream>
using namespace std;
int main()
{
  int n;
  cout<<"Enter Number Of Rows:"<<endl;
  cin>>n;
  int px=1;
  int py=n*2-1;
  for(int i=1;i<=n;i++)
  {
      for(int j=1;j<n*2;j++)
      {
          if(j>=px && j<=py)
          {
              cout<<"*";
          }
          else
          {
              cout<<" ";
          }
      }
      px++;
      py--;
      cout<<endl;
  }
}

