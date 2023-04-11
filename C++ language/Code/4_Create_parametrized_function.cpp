#include <iostream>
using namespace std;

class Date //declare a class
{
    int day;
    int month;
    int year;

  public:
         void get (int, int, int);
         void show (void);
};

void Date :: get (int d, int m, int y)
{
    day = d;
    month = m;
    year = y;
}

void Date :: show (void)
{
    cout <<day <<"/"<<month <<"/" <<year <<endl;
}

int main()
{
    Date D1, D2;
    D1.get(23,1,1999);
    D1.show();
    D2.get(25,8,2022);
    D2.show();
}