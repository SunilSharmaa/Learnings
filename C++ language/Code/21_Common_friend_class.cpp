#include <iostream>
using namespace std;

class Beta;
class Alpha
{
        int a;
    public:
        void get()
        {
            cout<<"enter the value of Alpha = ";
            cin>>a;
        }
        void show()
        {
            cout<<"value of alpha is = "<<a<<endl;
        }
        friend void compare(const Alpha &, const Beta &);
};
class Beta
{
        int b;
    public:
        void get()
        {
            cout<<"enter the value of beta = ";
            cin>>b;
        }
        void show()
        {
            cout<<"value of Beta is = "<<b<<endl;
        }
        friend void compare(const Alpha &, const Beta &);
};
void compare(const Alpha &c_Alpha, const Beta &c_Beta)
{
    if(c_Alpha.a > c_Beta.b)
        cout<<"value of Alpha "<<c_Alpha.a<<" is Greater"<<endl;
    else if(c_Alpha.a < c_Beta.b)
        cout<<"value of Beta "<<c_Beta.b<<" is Greater"<<endl;
    else    
        cout<<"Both are Equal"<<endl;
}

int main()
{
    Alpha a1;
    Beta b1;

    a1.get();
    b1.get();
    a1.show();
    b1.show();
    compare(a1,b1);
return 0;
}