/* String #59 - Check if the string is Palindrome or not. */

#include <stdio.h>
#include <string.h>

int main()
{
    int i, j;
    char str[30], rev[30];
    
    printf("Enter Any string = ");
    scanf("%s",str);
    
    for(i=0;str[i]!='\0';i++);
    
    for(i=i-1,j=0;i>=0;i--,j++)
        rev[j]=str[i];
        
    rev[j]='\0';
        
    if(strcmp(str,rev)==0)
        printf("String is Palindrome");
    
    else
        printf("Not a Palindrome");
    
    
    
}