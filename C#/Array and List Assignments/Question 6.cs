namespace Array_and_List_Q6
{
    internal class SumOfArray
    {
        static void Main()
        {
            int sizeOfArray = 0;

            //checking for valid size input
            try
            {
                //asking user to enter size of the array
                Console.WriteLine("Enter the size of the array ");
                sizeOfArray = Convert.ToInt32(Console.ReadLine());

                if (sizeOfArray == 0 || sizeOfArray < 0)
                {
                    throw new ArgumentException();
                }
            }
            //displaying exception for different format
            catch (FormatException)
            {
                Console.WriteLine("Exception!! \nPlease enter integer number only (greater then zero)");
                return;
            }
            //displaying exception for value enter 0 or less then 0
            catch (ArgumentException)
            {
                Console.WriteLine("Exception!! \nValue 0 or less then 0 not allowed");
                return;
            }

            int[] arrayOfNumbers = new int[sizeOfArray];
            Console.WriteLine("enter {0} elements", sizeOfArray);

            int sum = 0;
            //taking elements  from the user and also calculating sum of all the even number
            for (int i = 0; i < sizeOfArray; i++)
            {
                //checking if the user is giving valid integer input
                try
                {
                    arrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
                    if (arrayOfNumbers[i] % 2 == 0)
                    {
                        sum = sum + arrayOfNumbers[i];
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Exception!! \nEnter only integer numbers");
                    return;
                }
            }

            Console.WriteLine("Sum of All the Even number of the array is : {0}.", sum);
        }
    }
}