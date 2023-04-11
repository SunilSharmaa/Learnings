/* Array #51 - Initialise a Matrix 3*3 from user and calculate the given below.
    (1. sum of all the elements
    2. sum of all the  row elements 
    3. sum of all the column elements
    4. sum of elements in diogonal.
        */
#include <stdio.h>

int main()
{
    int arr[3][3], i, j, sum=0;
    
    //Taking input from the user
    
    for(i=0;i<3;i++)
    {
        for(j=0;j<3;j++)
            {
                printf("Enter the Elements = ");
                scanf("%d",&arr[i][j]);
            }
    }
    
    //Calculating sum of all the elements
    for(i=0;i<3;i++)
    {
        for(j=0;j<3;j++)
            sum=sum + arr[i][j];
    }
    printf("Sum of all the elements is = %d",sum);
    
    //Calculating sum of row
    
    
    
    return 0;
}
