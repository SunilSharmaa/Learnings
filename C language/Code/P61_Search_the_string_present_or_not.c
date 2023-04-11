/* String #61 - Accept 10 name from the user and take another name then search the given name presenr or not. */


#include <stdio.h>
#include <string.h>

int main()
{
    int i;
    char str[10][20], name[20];
    
    for(i=0; i<10; i++){
        printf("Enter name %d = ",i+1);
        scanf("%s",str[i]);
    }
    
    printf("Enter another Name = ");
    scanf("%s",name);
    
    for(i=0;i<10;i++){
        if(strcmp(name,str[i])==0){
         printf("%s Found at name no. %d",name,i+1);
         break;
        }
    }
    
    if(i==10)
        printf("Not Found");
    
    


    return 0;
}
