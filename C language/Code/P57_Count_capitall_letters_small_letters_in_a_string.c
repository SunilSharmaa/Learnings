/* String #57 - Accept a string with space and count Capital letters, small Letters, digits, space and other symbol  */
#include <stdio.h>

int main()
{
    int i,  c1=0, c2=0, c3=0, c4=0, c5=0;
    char str[30];
    printf("Enter any string\n");
    scanf("%[^\n]s",str);
    
    for(i=0;str[i]!='\0';i++)
        {
            if(str[i]>='a' && str[i]<='z')
                c2++;
            
            else if(str[i]>='A' && str[i]<='Z')
                c1++;
            
            else if(str[i]>='0' && str[i]<='9')
                c3++;
                
            else if(str[i]==' ')
                c4++;
            
            else
                c5++;
        }
    printf("Capital Letters = %d\nSmall Letters = %d\nDigits = %d\nSpaces = %d\nOther Symbols = %d",c1,c2,c3,c4,c5);
    return 0;
}