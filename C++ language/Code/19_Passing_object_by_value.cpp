#include <iostream>
using namespace std;

class Box
{
        int l,b,h;
    public:
        Box(int l, int b, int h)
        
        {
            this->l=l;
            this->b=b;
            this->h=h;
        }
        void show()const
        {
            cout<<"l= "<<l<<", b= "<<b<<", h= "<<h<<endl;
        }
        int comparevol(Box &c1) const
        {
            int vol1,vol2;
            vol1=l*b*h;
            vol2=c1.l*c1.b*c1.h;

            if(vol1>vol2)
                return 0;
            else if(vol2>vol1)
                return 1;
            else 
                return 2;
        }
};

int main()
{
    Box B1(1,2,3);
    Box B2(4,5,6);
    
    B1.show();
    B2.show();
    
    int cmpr = B1.comparevol(B2);
    if(cmpr==0)
        cout<<"B1 is Greatest"<<endl;
    else if(cmpr==1)
        cout<<"B2 is Greatest"<<endl;
    else 
        cout<<"Both are equal"<<endl;
return 0;
}