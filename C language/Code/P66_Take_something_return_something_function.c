// #4 Functions -> Take something Return something

int sum(int, int);
#include <stdio.h>

void main(){

    int a, b, c;
    printf("\nEnter any two integer = ");
    scanf("%d%d",&a, &b);
    
    c= sum(a, b);
    printf("Sum of Two number is = %d\n\n",c);

}
int sum(a, b){
    int c;
    c = a+b;
    return(c);
}