#include <iostream>
#include <cstring>
using namespace std;

class Emp
{
    int age;
    char name[20];
    float sal;
    static int count;
public:
        Emp(int, char*, float);
        void show();
        static void showcount();
        
        ~Emp();
};
int Emp::count;
Emp :: Emp(int c_age, char *c_name, float c_sal)
{
    age = c_age;
    strcpy(name,c_name);
    sal = c_sal;
    count++;
}
void Emp :: show()
{
    cout <<"age - " << age <<endl << "name - " << name <<endl<< "sal - " << sal <<endl;
}
void Emp :: showcount()
{
    cout << "total no. of employes are = " <<count<<endl;
}
Emp::~Emp()
{
    count--;
}
int main()
{
    Emp::showcount();
    {
    
    Emp E1(24,"gamma",45000.20);
    Emp E2(25,"anirush",65000.10);
    E1.show();
    E2.show();
    Emp::showcount();
    {
        Emp E3(25,"Ravi",30000.500);
        Emp E4(22,"Aman",42000.20);
        E3.show();
        E4.show();
        Emp::showcount();
    }Emp::showcount();
    }
    Emp::showcount();
return 0;
}