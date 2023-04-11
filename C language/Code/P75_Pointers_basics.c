// #13 Pointers -> Basics

#include <stdio.h>

int main(){

    int a=10;
    int *p,**q,***r;

    p=&a;
    q=&p;
    r=&q;
    printf("%d\n",*p);
    ***r=20;
    printf("%d\n",&a);
    printf("%d\n",p);
    

    printf("%d\n",&a);
    printf("%d\n",q);
    printf("%d\n",**q);


    return 0;
}
