/* String #62 - Accept five name from the user and display each name in reverse order */


#include <stdio.h>
#include <string.h>

int main()
{
    
    char str[5][20];
    int i,l,j;
    
    printf("Enter any Five name\n");
    for(i=0;i<5;i++){
        printf("%d. ",i+1);
        scanf("%s",str[i]);
    }
    printf("Reverse names are\n");
    
    for(i=0;i<5;i++){
        l=strlen(str[i]);
            for(j=l-1;j>=0;j--){
                printf("%c",str[i][j]);
    }printf("\n");
    }

    return 0;
}
