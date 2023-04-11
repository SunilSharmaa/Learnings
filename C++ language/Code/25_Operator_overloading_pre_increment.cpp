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
        Counter operator ++();
};
Counter Counter :: operator ++()
{
    ++count;
    return *this;
}

int main()
{
    Counter C1(10),C2;

    C1.show();
    C2.show();
    C2=++C1;
    C1.show();
    C2.show();
}