#include <iostream>
using namespace std;

class Circle
{
    int rad;
    const float pi;
public:
    Circle(int rad):pi(3.14),rad(rad){}
    void area()
    {    
        auto ar = pi * rad * rad;
        cout<< "Area = "<<ar<<endl;
    }
};

int main()
{
    Circle C1(5);
    C1.area();
return 0;
}