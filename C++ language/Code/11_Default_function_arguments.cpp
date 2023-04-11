#include <iostream>
using namespace std;

void Area (int, int=0);

int main()
{
    int choice;
    cout << "Select a figure" << endl << "1.Square" << endl << "2.Rectangle" <<endl;
    cin >> choice;
    switch(choice)
    {
        case 1:
                int s;
                cout <<"Enter the side = "; 
                cin >> s;
                Area(s);
                break;
        case 2:
                int l, b;
                cout << "Enter length and breadth = ";
                cin >> l >> b;
                Area(l,b);
                break;
        default:
                cout << "Invalid input";

    }
    return 0;
}
void Area (int a, int b)
{
    if(b==0)
        cout << "Area of Square = " << a*a <<endl;
    else
        cout << "Area of Rectangle = " << a*b <<endl;
}