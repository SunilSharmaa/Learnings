#include <iostream>
#include <string.h>


using namespace std;

class Emp
{
    char *p;
    int age;
    float sal;
public:
        Emp();
        void show();
        ~Emp();
};
Emp :: Emp()
{
    char name[20];
    cout << "Enter your name = ";
    cin.getline(name,20);
    cout << "Enter your age and salary = ";
    cin >> age >> sal;

    int l;
    l=strlen(name);
    p=(char*)malloc((l+1)*sizeof(char));
    strcpy(p,name);
}
void Emp:: show()
{
    cout << p <<", " <<age << ", " << sal <<endl;
}
Emp :: ~Emp()
{
    free(p);
}
int main()
{
    Emp E1;
    E1.show();
return 0;
}