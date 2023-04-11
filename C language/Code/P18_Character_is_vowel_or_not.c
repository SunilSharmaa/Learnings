/* Conditional Statement #18 - Check the character is vowel or not (small character)*/
#include <stdio.h>

int main()
{
   
    char vwl;
    printf("Enter any small character = ");
    scanf("%c",&vwl);
    
    if(vwl=='a')
        printf("%c is vowel",vwl);
    
    else if(vwl=='e')
        printf("%c is vowel",vwl);
    
    else if(vwl=='i')
        printf("%c is vowel",vwl);
    
    else if(vwl=='o')
        printf("%c is vowel",vwl);
        
    else if(vwl=='u')
        printf("%c is vowel",vwl);  
        
    else
        printf("not a vowel");
    
    return 0;
}
