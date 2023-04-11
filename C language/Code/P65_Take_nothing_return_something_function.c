// #3 Functions -> Take nothing Return something

int sum(void);
#include <stdio.h>

void main(){

    int c;
    
    c= sum();
    printf("Sum of Two number is = %d\n\n",c);

}
int sum(void){
    int a, b, c;
    printf("\nEnter any two integer = ");
    scanf("%d%d",&a, &b);
    c = a+b;
    return(c);
}