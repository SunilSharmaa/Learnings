#include <iostream>
using namespace std;

class Distance
{
        int feet;
        int inches;
    public:
        void get()
        {
            cout<<"enter feet and inches ";
            cin>>feet>>inches;
        }
        void add(const Distance&, const Distance&);
        void show()
        {
            cout<<"feet= "<<feet<<endl;
            cout<<"inches= "<<inches<<endl;
        }
};
void Distance :: add(const Distance &c_f, Distance const &c_i)
{
    feet = c_f.feet + c_i.feet;
    inches = c_f.inches + c_i.inches;

    if(inches>=12)
    {
        feet= feet+ (inches/12);
        inches= inches%12;
    }
}

int main()
{
    Distance D1,D2,D3;

    D1.get();
    D2.get();
    D3.add(D1,D2);
    D1.show();
    D2.show();
    D3.show();
return 0;
}