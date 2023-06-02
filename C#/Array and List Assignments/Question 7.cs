namespace Array_and_List_Q7
{
    class SmallestAndLargestElement
    {
        static void Main()
        {
            int sizeOfArray = 0;
            //checking for valid size input
            try
            {
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


            for (int i = 0; i < sizeOfArray; i++)
            {
                try
                {
                    arrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Exception!! \nEnter only integer numbers");
                    return;
                }
            }

            //declaring 2 varible and storing 0th index value in the variable
            int largest = arrayOfNumbers[0];
            int smallest = arrayOfNumbers[0];

            for (int i = 0; i < sizeOfArray; i++)
            {
                    //comparing elements and if the element is greater then the largest variable we,ll store that value in largest varible.
                    if (arrayOfNumbers[i] > largest)
                    {
                        largest = arrayOfNumbers[i];
                    }

                    //comparing elements and if the element is smaller then the smallest variable we,ll store that value in smallest varible.
                    if (arrayOfNumbers[i] < smallest)
                    {
                        smallest = arrayOfNumbers[i];
                    }
                
            }

            Console.WriteLine("Largest element is : {0}", largest);
            Console.WriteLine("Smallest element is : {0}", smallest);
        }
    }
}