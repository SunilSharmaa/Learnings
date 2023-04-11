// #9 Functions -> Accept integer value from the main() and calculate the factorial but print it in main().

#include <stdio.h>

int factorial(int);
int main(){
    int num, f;
    printf("Enter any number = ");
    scanf("%d",&num);

    f=factorial(num);
    printf("Factorial of %d is = %d\n",num,f);

    return 0;
}
int factorial(int num){
    int i;
    for(i=1;num>1;num--)
        i=i*num;
    
    return (i);
}
