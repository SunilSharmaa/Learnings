/* String #58 - Accept a string and convert all small letter into capital letters or vice versa  */
#include <stdio.h>

int main()
{
    int i;
    char str[30];
    printf("Enter any string\n");
    scanf("%[^\n]s",str);
    
    for(i=0;str[i]!='\0';i++)
        {
            if(str[i]>='a' && str[i]<='z')
                str[i]=str[i]-32;
            
            else if(str[i]>='A' && str[i]<='Z')
                str[i]=str[i]+32;
                
        }
        printf("%s",str);
}