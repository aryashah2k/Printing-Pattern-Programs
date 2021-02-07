#include<iostream>
#include<cmath>
using namespace std;
int main()
{
    int n;
    cout<<"Enter Number Of Rows:"<<endl;
    cin>>n;
    for(int i=1;i<=n;i++)
    {
        for(int j=n-1;j>=i;j--)
        {
            cout<<" ";
        }
        for(int k=i-1;k>=-(i-1);k--)
        {
            cout<<i-abs(k);
        }
        cout<<endl;
    }
}

