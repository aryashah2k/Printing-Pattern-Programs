#include<iostream>
using namespace std;
int main()
{
    int min_stars;
    cout<<"Enter Minimum Number Of Stars:"<<endl;
    cin>>min_stars;
    //Enter Odd Number For Odd Number Of Stars In Each Row
    //Enter Even Number For Even Number Of Stars In Each Row
    int pyramid_height;
    cout<<"Enter Pyramid Height:"<<endl;
    cin>>pyramid_height;
    int pyramid_space=pyramid_height-1;
    for(int i=0;i<pyramid_height;i++)
    {
        for(int j=pyramid_space;j>i;j--)
        {
            cout<<" ";
        }
            for(int k=0;k<min_stars;k++)
            {
                cout<<"*";
            }
            min_stars=min_stars+2;
            cout<<endl;
    }
}

//Alternative Logic Using If-Else
#include<iostream>
using namespace std;
int main()
{
    int n;
    cout<<"Enter Number Of Rows:"<<endl;
    cin>>n;

    int px=n;//Left Print Control
    int py=n;//Right Print Control

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
        px--;
        py++;
        cout<<endl;
    }
}
