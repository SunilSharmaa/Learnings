// Q-> WAP to create a class called worker and calculates its salary 
//(upto 40h the salry will be rate per hour * working hours )
//(for more than 40h, the rph will be doubled)


#include <iostream>
using namespace std;

//creating a class called Worker containg workers details
class Worker
{
    int hrswrkd; //storing working hours number
    int rph;  //rate per hour 
    int sal; //salary

    public:
            void get();
            void calculatesal();
            void show();
};

//defining get function
void Worker :: get()
{
    cout<<"Enter Working hours number = ";
    cin>>hrswrkd;
    cout<<"Enter Rate per hours = ";
    cin>>rph;
}

//defining calculatesal function
void Worker  :: calculatesal()
{
    int bonus;
    
    if(hrswrkd>40)
    {
        bonus = hrswrkd - 40;
        bonus = bonus * (rph * 2);
        sal   = rph * 40;
        sal   = sal + bonus;
    }
    else
    {
        sal = rph * hrswrkd;
    }
}

//defining show function
void Worker :: show()
{
    cout<<"The salary of the worker is = "<<sal<<endl;
}

//main function
int main()
{
    Worker emy;
    emy.get();
    emy.calculatesal();
    emy.show();

return 0;
}