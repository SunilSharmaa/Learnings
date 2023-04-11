// #17 Pointers -> using array , pointer and functions (do reverse sorting). 

#include <stdio.h>

void input (int*);
void display (int*);
void revsort (int*);

int main(){
    int arr[5];
    input(arr);
    display(arr);
    revsort(arr);
    printf("Reverse Sorted arrays are\n");
    display(arr);
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
void revsort (int *p){ //reverse sorting function
    int round, temp, i;
    for(round=1;round<=4;round++){
        for(i=0;i<=4-round;i++){
            if(*(p+i) < *(p+i+1)){
                temp = *(p+i);
                *(p+i) = *(p+i+1);
                *(p+i+1) = temp;
            }
        }
    } 
    
}