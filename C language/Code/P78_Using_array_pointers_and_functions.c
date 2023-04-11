// #16 Pointers -> using array , pointer and functions.

#include <stdio.h>

void input (int*);
void display (int*);
void sort (int*);

int main(){
    int arr[5];
    input(arr);
    display(arr);
    sort(arr);
    printf("\n");
}
void input (int *p){ //input function
    int i;
    printf("\nEnter five elements of array = ");
    for(i=0;i<5;i++)
        scanf("%d",p+i);
}
void display (int *p){ //display function
    int i;
    printf("Entered array are\n");
    for(i=0;i<5;i++){
        printf("%d ",*(p+i));
    }
}
void sort (int *p){ //sorting function
    int round, temp, i;
    for(round=1;round<=4;round++){
        for(i=0;i<=4-round;i++){
            if(*(p+i)>*(p+i+1)){
                temp = *(p+i);
                *(p+i) = *(p+i+1);
                *(p+i+1) = temp;
            }
        }
    } 
    printf("\nSorted array are\n");
    for(i=0;i<=4;i++)
        printf("%d ",*(p+i));
}