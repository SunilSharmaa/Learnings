#include <iostream>
using namespace std;

class call
{
    public:
            call();
            ~call();
};
call :: call()
{
    cout << "Constructor Called" <<endl;
}
call :: ~call()
{
    cout << "Destructor Called" << endl;
}
int main()
{
    call c1;
    {
        call c2;
    }
return 0;
}