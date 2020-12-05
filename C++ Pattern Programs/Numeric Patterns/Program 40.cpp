#include<iostream>
using namespace std;
int main()
{
    int z=1;
    int n;
    cout<<"Enter Number of Rows:"<<endl;
    cin>>n;
    for(int i=0;i<n;i++)
    {
        for(int j=n-1;j>i;j--)
        {
            cout<<" ";
        }
        for(int k=z;k>=1;k--)
        {
            cout<<k;
        }
        z+=2;
        cout<<endl;
    }
}
