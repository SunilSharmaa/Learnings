#include <iostream>
#include <string.h>
using namespace std;

class Employe
{
    int age;
    char name[20];
    float sal;

   public:
           Employe(int,char*,float);
           void show();
};

Employe :: Employe(int a, char* n, float s)
{
    age = a;
    strcpy(name,n);
    sal = s;
}

void Employe :: show()
{
    cout <<"age = " <<age <<endl;
    cout <<"name = " <<name <<endl;
    cout <<"salary = " <<sal <<endl <<endl;
}

int main()
{
    Employe E1(23,"Ram",15000.30), E2(25,"Ankit",30000.30);
    E1.show();
    E2.show();

return 0;
}