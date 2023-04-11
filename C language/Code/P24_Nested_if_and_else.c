/* Nested if Statements #24 - an insurance comany to provide loan to given criteria  (person shuld be married, (if unmarried->male->age 40>)
(female -> age 35> ) */
#include <stdio.h>

int main()
{
    char ms, gender;
    int age;

    printf("Enter Marital status (m/u) = ");
    scanf("%c", &ms);
    getchar(); // Clear input buffer
    printf("Enter your Gender (M/F) = ");
    scanf("%c", &gender);
    getchar(); // Clear input buffer
    printf("Enter your Age = ");
    scanf("%d", &age);

    if(ms == 'm' || ms == 'M')
    {
        printf("Insurance Provided");
    }
    else if(ms == 'u' || ms == 'U')
    {
        if(gender == 'm' || gender == 'M')
        {
            if(age >= 40)
            {
                printf("Insurance Provided");
            }
            else
            {
                printf("Insurance Not Provided");
            }
        }
    }
    else if(ms == 'f' || ms == 'F')
    {
        if(age >= 35)
        {
            printf("Insurance Provided");
        }
        else
        {
            printf("Insurance Not Provided");
        }
    }
    else
    {
        printf("Invalid input");
    }

    return 0;
}
