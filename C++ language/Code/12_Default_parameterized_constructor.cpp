#include <iostream>
using namespace std;

class Student
{
    int roll;
    char grade;
    float per;

public:
        Student(int=0, char=' ', float=0.0);
        void get();
        void show();
};

Student :: Student(int a, char c, float g)
{
    roll = a;
    grade = c;
    per = g;
}
void Student :: get()
{
    cout << "Enter Roll, Grade and Percentage = ";
    cin >> roll >> grade >> per;
}

void Student :: show()
{
    cout << "Roll = " <<roll << endl;
    cout << "Grade = " <<grade << endl;
    cout << "Percentage = " <<per << endl;
}

int main()
{
    Student S1(45,'A',85.56);
    Student S2;

    S2.get();
    S1.show();
    S2.show();
return 0;
}