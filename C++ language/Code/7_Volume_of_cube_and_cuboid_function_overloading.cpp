#include <iostream>
using namespace std;

void volume (int);
void volume (int, int, int);

int main()
{
    cout <<"Select a Figure" <<endl;
    cout <<"1. Cube  " <<"2. Cuboid"<<endl;
    int choice;
    cin >>choice;

    switch(choice)
    {
        case 1:
                cout <<"Enter the Side of the Cube " <<endl;
                int side;
                cin >> side;
                volume(side);
                break;
        case 2:
                cout <<"Enter l,b,h of cuboid"<<endl;
                int l,b,h;
                cin >> l>>b>>h;
                volume(l,b,h);
                break;
        default:
                cout <<"invalid input" <<endl;        
    }
return 0;
}
void volume (int s) //function defination
{
    cout <<"The volume of cube is = " << s*s*s << endl;
}
void volume (int l, int b, int h) //function defination
{
    cout <<"The volume of cuboid is = " << l*b*h <<endl;
}