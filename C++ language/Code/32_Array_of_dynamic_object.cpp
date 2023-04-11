#include <iostream>
using namespace std;

class Box {
    int l,b,h;
public:
    void get () {
        
        cin>>l>>b>>h;
    }

    void show () {
        cout <<"l= "<<l<<", "<<"b= "<<b<<", "<<"h= "<<h<<endl;
    }
};

int main () {
    cout<<"enter the size of objects= ";
    int size; 
    cin>>size;

    Box *box_ptr;
    box_ptr= new Box[5];

    cout<<"enter "<<size<<" l,b and h= ";
    for (int i=0; i<size; i++)
        box_ptr[i].get();
    
    for (int i=0; i<size; i++)
        box_ptr[i].show();
return 0;
}