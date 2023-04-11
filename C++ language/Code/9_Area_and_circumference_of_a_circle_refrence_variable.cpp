#include <iostream>
using namespace std;

void Calculate (int, float &, float &);

int main()
{
    int rad;
    float area,circum;
    cout<<"Enter the Radius of Circle = ";
    cin>>rad;
    Calculate(rad, area, circum);
    cout<<"Radius of the circle is  = " <<area <<endl;
    cout<<"Circumference of the circle is = "<<circum <<endl;
return 0;
}
void Calculate (int rad, float & area, float & circum)
{
    area = 3.14 * rad * rad;
    circum = 2 * 3.14 * rad;
}
