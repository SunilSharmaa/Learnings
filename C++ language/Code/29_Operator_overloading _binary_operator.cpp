#include <iostream>
using namespace std;

class Distance {
    int feet;
    int inches;
public:
    void get () {
        cout<< "enter feet and inches= ";
        cin>>feet>>inches;
    }
    void show () {
        cout<< "feet= "<<feet<<endl<< "inches= "<<inches<<endl;
    }
    Distance operator + (const Distance &) const;
};

Distance Distance :: operator + (const Distance & c_) const {
    Distance temp;
    temp.feet = feet + c_.feet;
    temp.inches = inches + c_.inches;

    if (temp.inches >= 12) {
        temp.feet = temp.feet + (temp.inches/12);
        temp.inches = temp.inches%12;
    }
    return temp;
}

int main () {
    Distance D1,D2,D3,D4;
    D1.get();
    D2.get();
    D3.get();

    D4 = D1 + D2 + D3;

    D1.show();
    D2.show();
    D3.show();
    D4.show();
return 0;
}