#include<iostream>
using namespace std;
int main()
{
    int n;
    cout<<"Enter Number Of Rows:"<<endl;
    cin>>n;
    int z=1;
    for(int i=0;i<n;i++)
    {
        for(int j=n-1;j>i;j--)
        {
            cout<<" ";
        }
        for(int k=0;k<z;k++)
        {
            cout<<z-i;
        }
        z+=2;
        cout<<endl;
    }
}
