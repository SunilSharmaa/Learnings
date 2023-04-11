// #19 Structure -> basics

#include <stdio.h>  
#include <string.h>  
  
struct sum{
    int a, b;
};

void main(){
    struct sum add;
    
    printf("\nEnter two no.  to add = ");
    scanf("%d %d",&add.a, &add.b);

    printf("%d\n\n",add.a + add.b);
   

}