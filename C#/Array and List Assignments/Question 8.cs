namespace Array_and_List_Q8
{
    class Program
    {
        static void Main()
        {
            int sizeOfArray = 0;

            try
            {
                //asking for the size of the array then we will create 2 arrays of same size
                Console.Write("Enter the size of the array: ");
                sizeOfArray = Convert.ToInt32(Console.ReadLine());

                if (sizeOfArray == 0 || sizeOfArray < 0)
                {
                    throw new ArgumentException();
                }
            }
            //displaying exception for different format
            catch (FormatException)
            {
                Console.WriteLine("Exception!! \nEnter only positive integer number (greater then 0)");
                return;
            }
            //displaying exception for 0 or less then 0 input
            catch (ArgumentException)
            {
                Console.WriteLine("Exception!! \nvalue 0 or less then 0 is not allowed");
                return;
            }

            int[] firstArray = new int[sizeOfArray];
            int[] secondArray = new int[sizeOfArray];

            //taking elements of first array
            Console.WriteLine("enter the {0} elements of first array", sizeOfArray);
            for (int i = 0; i < sizeOfArray; i++)
            {
                try
                {
                    firstArray[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Exception!! \nInvalid input, please enter only integer number");
                    return;
                }
            }

            //taking elements of 2nd array
            Console.WriteLine("enter the {0} elements of second array", sizeOfArray);
            for (int i = 0; i < sizeOfArray; i++)
            {
                try
                {
                    secondArray[i] = Convert.ToInt32(Console.ReadLine());
                }

                catch (FormatException)
                {
                    Console.WriteLine("Exception!! \nInvalid input, please enter only integer number");
                    return;
                }
            }
            //will check if the array's elements are equal or not
            int count = 0;
            for (int i = 0; i < sizeOfArray; i++)
            {
                if (secondArray[i] != firstArray[i])
                {
                    Console.WriteLine("\nNot Equal");
                    break;
                }
                count++;
            }

            if (count == sizeOfArray)
            {
                Console.WriteLine("\nEqual");
            }
        }
    }
}