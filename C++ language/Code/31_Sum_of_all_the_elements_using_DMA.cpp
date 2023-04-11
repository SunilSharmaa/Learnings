#include <iostream>
using namespace std;

class MyArray {
    int *p;
    int n;
    int sum;
public:
    MyArray () {
        cout<< "enter size of the array= ";
        cin>>n;
        p = new int[n];

        if (p==0) {
            cout<< "insufficient memory"<<endl;
            exit(1);
        }

        sum=0;
    }

    ~MyArray () {
        delete []p;
        cout<< "memory deallocated successfully"<<endl;
    }

    void get ();
    void calculate ();
    void show ();

};

void MyArray :: get () {
    cout<< "enter " <<n<<" int no= ";
    for (int i = 0; i<n; i++) {
        cin>> p[i];
    }
}

void MyArray :: calculate () {
    for (int i=0; i<n; i++) 
        sum = sum + p[i];
}

void MyArray :: show () {
    cout<< "entered elements are"<<endl;
    for (int i=0; i<n; i++) {
        cout<< p[i] <<endl;
    }
    
    cout<< "sum of all the array is= "<<sum<<endl;
}

int main () {
    MyArray A1;
    A1.get ();
    A1.calculate ();
    A1.show ();

return 0;
}