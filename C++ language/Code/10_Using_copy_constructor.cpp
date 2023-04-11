#include <iostream>
using namespace std;

class Box //created a class
{
    int l, b, h;
public:
        Box();
        Box(int);
        Box(int, int, int);
        Box(Box&);
        void show();
};

Box :: Box() //non parameterized constructor
{
    cout<<"Enter length, breadth & height = ";
    cin>> l >> b >> h;
    
}
Box :: Box(int s)
{
    l=b=h=s;
}
Box :: Box(int a, int c, int d)
{
    l = a;
    b = c;
    h = d;
}
Box :: Box(Box &p)
{
    l = p.l;
    b = p.b;
    h = p.h;
}
void Box :: show()
{
    cout << l <<" "<< b <<" "<< h<<" "<< endl;
}
int main()
{
    Box b1;
    Box b2(6);
    Box b3(3,7,1);
    Box b4(b1);

    b1.show();
    b2.show();
    b3.show();
    b4.show();
return 0;
}