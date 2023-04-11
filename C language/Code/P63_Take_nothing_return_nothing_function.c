// #1 Functions -> Take nothing Return nothing

void sum(void);
#include <stdio.h>

void main(){

    
    sum();

}
void sum(){
    int a, b, c;
    printf("Enter any Two integer number = ");
    scanf("%d %d",&a,&b);
    c=a+b;
    printf("Sum of two digit is = %d\n",c);
}