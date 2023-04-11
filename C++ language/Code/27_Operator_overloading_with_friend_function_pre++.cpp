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
        friend Counter operator ++(Counter &);
};
Counter operator ++(Counter &c_C1)
{
    c_C1.count=c_C1.count+1;
    return c_C1;
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