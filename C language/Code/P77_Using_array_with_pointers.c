// #15 Pointers -> using array with pointers.

#include <stdio.h>

int main(){
    int arr[5], i, *p;

    printf("\nEnter five elements of array = ");
    for(i=0;i<5;i++)
        scanf("%d",p+i);
    
    printf("Entered Elements are = ");
    for(i=0;i<5;i++)
        printf("%d ",*(p+i));
}