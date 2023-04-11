#include <iostream>
using namespace std;

class Factorial //class created
{
    int fno;
    int num;

   public:
            Factorial();
            void get();
            void fact();
            void show();
};

Factorial :: Factorial() //constructor
{
    fno = 1;
}

void Factorial :: get() //member function defination 
{
    cout << "Enter any number = ";
    cin >> num;
}
void Factorial :: fact() //member function defination
{
    
    for (int i=1; i<=num; i++)
        fno = i * fno;
}
void Factorial :: show() //member function defination
{
    cout <<"Factorial is = " <<fno <<endl;
}

int main()
{
    Factorial f1;
    f1.get();
    f1.fact();
    f1.show();
return 0;
}