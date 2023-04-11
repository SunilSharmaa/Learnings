/* String #59(2nd method) - Check if the string is Palindrome or not. */

#include <stdio.h>
#include <string.h>

int main(){
    
    char str[20];
    int l,i;
    printf("Enter any string = ");
    scanf("%s",str);
    
    for(l=0;str[l]!='\0';l++);
    
    for(i=0;i<l/2;i++){
        if(str[i]!= str[l-1-i]){
            printf("Not a Palindrome");
            break;
        }
    }
    if(i==l/2)
        printf("String is Palindrome");
    
}