/* String #53 - accpt a string and display it line by line  */
#include <stdio.h>

int main()
{
    int i;
    char str[20];
    printf("Enter any string\n");
    scanf("%s",str);
    
    for(i=0;str[i]!='\0';i++)
        printf("%c\n",str[i]);
    
    return 0;
}
