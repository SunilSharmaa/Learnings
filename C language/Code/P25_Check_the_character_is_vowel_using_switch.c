/* Switch Statement #25 - check the character is vowel or not (small letters only using Switch statement) */
#include <stdio.h>

int main()
{
   
   char ch;
   printf("Enter a small character= ");
   scanf("%c",&ch);
   
   switch(ch)
   {
       case 'a':
       case 'e':
       case 'i':
       case 'o':
       case 'u':
            printf("%c is Vowel",ch);
            break;
       default:
            printf("%c is not a Vowel",ch);
   }
   
   
    
    return 0;
}
