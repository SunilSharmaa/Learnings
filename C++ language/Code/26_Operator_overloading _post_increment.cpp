#include <iostream>
using namespace std;

class Counter
{
        int count;
    public:
        Counter(int count)
        {
            this->count=count;
        }
        Counter()
        {
            count=0;
        }
        void show()
        {
            cout<<count<<endl;
        }
        Counter operator ++(int);
};
Counter Counter :: operator ++(int)
{
    Counter temp;
    temp.count=count;
    count++;
    return temp;
}

int main()
{
    Counter C1(10),C2;

    C1.show();
    C2=C1++;
    C1.show();
    C2.show();
}