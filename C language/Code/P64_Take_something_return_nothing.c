// #2 Functions -> Take something Return nothing

void sum(int, int);
#include <stdio.h>

void main(){

    int a, b;
    printf("Enter any Two integer = ");
    scanf("%d%d", &a, &b);
    sum(a, b);

}
void sum(a, b){
    int c;
    c = a+b;
    printf("Sum of two digit is = %d\n",c);
}