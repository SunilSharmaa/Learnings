// #22 Dynamic Memory Allocation -> 

#include <stdio.h>  
#include <stdlib.h>  

int main()
{
    int *p, i, n;
    printf("Enter the size of the array\n");
    scanf("%d",&n);

    p = (int*) malloc (n * sizeof (int));

    for(i=0; i<n; i++)
    {
        scanf("%d",&p[i]);
    }
    
    for(i=0; i<n; i++)
    {
        printf("%d\n",p[i]);
    }
    free(p);
}

