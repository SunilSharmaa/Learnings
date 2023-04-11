/* Conditional Statement #21 - Check the Character is capitall letter, small letter,digit or other symbol. */
#include <stdio.h>

int main()
{
   
   char ch;
   
   printf("Enter any Character = ");
   scanf("%c",&ch);
   
   if(ch>='a' && ch<='z')
        printf("Small Letters");
    
    else if(ch>='A' && ch<='Z')
        printf("Capital letters");
        
    else if(ch>='0' && ch<='9')
        printf("Digit");
        
    else 
        printf("other Symbol");
        
    return 0;
}
