/* String #60 - Accept three name from the user and calculate the length of each name. (without using predefined function */

#include <stdio.h>
#include <string.h>

int main(){
    
    char str[3][20];
    int i, j;
    
    for(i=0;i<3;i++)
    {
        printf("Enter the name = ");
        scanf("%s",str[i]);
    }
    
    for(i=0;i<3;i++){
        for(j=0;str[i][j]!='\0';j++);
        printf("\nName is %s and Length is %d",str[i],j);
    }
    
    }
    
