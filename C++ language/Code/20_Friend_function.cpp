#include <iostream>
using namespace std;

class Student
{
        int roll;
        char grade;
        float per;
    public:
        void get()
        {
            cout<<"Enter roll, grade and per = ";
            cin>>roll>>grade>>per;
        }
        friend void show(const Student &);
};
void show (const Student &p)
{
    cout<<"Roll= "<<p.roll<<"  Grade= "<<p.grade<<"  per= "<<p.per<<endl;
}
int main()
{
    Student S1,S2;
    S1.get();
    S2.get();
    show(S1);
    show(S2);
return 0;
}