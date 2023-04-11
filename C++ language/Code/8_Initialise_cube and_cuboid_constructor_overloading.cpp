#include <iostream>
using namespace std;

class Box //class created
{
    int l,b,h;
public:
        Box();
        Box(int);
        Box(int, int, int);
        void show();
};

Box :: Box() //constructor defination
{
    cout << "Enter l, b, h = ";
    cin >> l >> b >> h;
}

Box :: Box(int s) //Constructor with single arguments 
{
    l = b = h = s;
}

Box :: Box(int e, int f, int g) //Constructor with 3 arguments
{
    l = e;
    b = f;
    h = g;
}

void Box :: show() //member function
{
    cout << "l = " <<l;
    cout << "   b = " <<b;
    cout << "   h = " <<h <<endl;
}

int main () //main function
{
    Box B1;
    Box B2(10);
    Box B3(6,8,10);
    B1.show();
    B2.show();
    B3.show();
}