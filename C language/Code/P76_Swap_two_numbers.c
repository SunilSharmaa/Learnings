// #14 Pointers -> create a function to swap the two numbers and take input from the  main().

#include <stdio.h>

void swap(int*, int*);
int main(){
    int num1, num2;
    printf("\nEnter any two integer = ");
    scanf("%d%d",&num1, &num2);
    
    swap(&num1,&num2);
    printf("After swapping \nFirsts no. = %d\nSecond no. = %d\n\n",num1,num2);

    return 0;
}
void swap(int *a, int *b){
    int temp;
    temp = *a;
    *a = *b;
    *b = temp;
}