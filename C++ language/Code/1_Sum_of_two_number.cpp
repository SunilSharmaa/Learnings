// Q-> Calculate the sum of two number

#include <iostream>
#include <conio.h>
using namespace std;

class num
{
    int num1, num2, sum;

    public:
            void get();
            void show();
            void add();
};
void num::get()
{
    cout<<"Enter any two int number = ";
    cin>>num1>>num2;
}
void num::add()
{
    sum = num1 + num2;
}
void num::show()
{
    cout<<"The sum of "<<num1 <<" and " <<num2<<" is"<<endl;
    cout<<sum<<endl;
}
int main()
{
    num obj;

    obj.get();
    obj.add();
    obj.show();
}