#include <iostream>
using namespace std;

class BOX
{
        int l,b,h;
    public:
        BOX(int l, int b, int h)
        {
            this->l=l;
            this->b=b;
            this->h=h;
        }
        BOX(const BOX &c)
        {
            *this=c;
        }

        void show()
        {
            cout << "l= "<<l <<" b= "<<b <<" h= "<<h <<endl;
        }
};
int main()
{
    BOX B1(5,6,7);
    BOX B2(8,9,10);
    BOX B3(B1);
    B1.show();
    B2.show();
    B3.show();
}