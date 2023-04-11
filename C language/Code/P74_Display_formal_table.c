// #12 Functions -> Accept integer value from the main() and display the formal table.

#include <stdio.h>

void showtable (int);
int main(){

    int n;
    printf("\nEnter any integer number = ");
    scanf("%d",&n);

    showtable(n);

    return 0;

}
void showtable (int n){
    int i;
    
    for(i=1; i<=10; i++){
        printf("%d * %d = %d\n",n,i,n*i);
    }

}
