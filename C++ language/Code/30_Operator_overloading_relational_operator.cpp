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
    cout<< "feet= " <<feet << " inches = "<<inches<<endl;
  }

  bool operator == (const Distance &) const;

};

bool Distance :: operator == (const Distance & c_) const {
  int temp_x, temp_y;

  temp_x = feet * 12 + inches;
  temp_y = c_.feet * 12 + c_.inches;

  if (temp_x==temp_y)
    return true;
  else
    return false;
}

int main () {
  Distance D1,D2;

  D1.get ();
  D2.get ();
  D1.show ();
  D2.show ();
  
  if (D1 == D2)
    cout <<"equal"<<endl;
  else
    cout <<"not equal"<<endl;
}