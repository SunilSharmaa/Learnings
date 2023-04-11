#include <iostream>
using namespace std;

class A {
    int a;
public:
    int b;
    void set_ab ();
    int get_a ();
    void show_a ();
};

class B : public A {
    int c;
public:
    void multi ();
    void display ();
};

void A :: set_ab () {
    a=5;
    b=10;
}

int A :: get_a () {
    return a;
}

void A :: show_a () {
    cout<< "a = "<<a<<endl;
}

void B :: multi () {
    c = get_a () * b;
}

void B :: display () {
    cout<< "a = "<<get_a ()<<endl<<"b = "<<b<<endl<< "c = "<<c<<endl;
}

int main () {
    B B1;

    B1.set_ab ();
    B1.multi ();
    B1.show_a ();
    B1.display ();

    B1.b=20;
    B1.multi ();
    B1.display ();

return 0;
}