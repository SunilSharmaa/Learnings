// Q-> Calculate the area of circle


#include <iostream>
using namespace std;

//Creating a class called circle
class circle
{
    float rad;
    float ar;
    float circumf;

    public:
            void get();
            void area();
            void show();
            void calcircumf();
};

//defining get function
void circle :: get()
{
    cout<<"Enter the Radius of Circle = ";
    cin>>rad;
}

//defining area function
void circle :: area()
{
    ar = 3.141 * rad * rad;
}

//defining show function
void circle :: show()
{
    cout<<"Area of Circle is = "<< ar <<endl;
    cout<<"Circumfrence of the Circle is = "<< circumf <<endl;
}

//defining calcircumf function
void circle :: calcircumf()
{
    circumf = 2 * 3.141 * rad;
}

//main function
int main()
{
    circle Crl;

    Crl.get();
    Crl.area();
    Crl.show();

return 0;
}