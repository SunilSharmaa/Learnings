#include <iostream>
using namespace std;

class Account
{
        char name[20];
        int balance;
    public:
        void get()
        {
            cout<<"enter name and balance= ";
            cin>>name>>balance;
        }
        void show() const
        {
            cout<<"name= "<<name<<endl<<"balance= "<<balance<<endl;
        }
        void transfer(Account & c_Account, const int amount)
        {
            if(c_Account.balance-amount <=500)
            {
                cout<<"transaction failed"<<endl;
            }
            else
            {
                balance = balance + amount;
                c_Account.balance = c_Account.balance - amount;
            }
        }
};

int main()
{
    Account A1,A2;
    A1.get();
    A2.get();
    
    cout<<"enter the amount you want to transfer= ";
    int amount;
    cin>>amount;

    A2.transfer(A1,amount);
    A1.show();
    A2.show();

}