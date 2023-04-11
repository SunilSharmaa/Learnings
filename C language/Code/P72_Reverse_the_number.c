// #10 Functions -> Accept integer value from the main() and reverse the number and print it in main().

#include <stdio.h>

int reverse (int);
int main(){

    int num, rev;
    printf("\nEnter any integer no = ");
    scanf("%d",&num);

    rev= reverse(num);
    printf("Reverse no. is = %d\n\n",rev);

    return 0;
}
int reverse (int n){
    int temp,rev=0;
    while(n!=0){
        temp= n%10;
        rev= rev*10+temp;
        n= n/10;
    }
    return(rev);
}
