#include <iostream>
using namespace std;

class Num
{
        int num1,num2;
    public:
        Num(int num1, int num2)
        {
            this->num1=num1;
            this->num2=num2;
        }
        void show()
        {
            cout<<"num1= "<<num1<<endl <<"num2= "<<num2<<endl;
        }
        friend class Addnum;
};
class Addnum
{
        int total;
    public:
        void calculate (const Num &c)
        {
            total= c.num1+c.num2;
        }
        void display(const Num &c)
        {
            cout<<"total of "<<c.num1<<" and "<<c.num2<< " is "<<total<<endl; 
        }

};

int main()
{
    Num n1(5,6);
    Addnum an1;
    n1.show();
    an1.calculate(n1);
    an1.display(n1);
return 0;
}