namespace Array_and_List_Q7
{
    class SmallestAndLargestElement
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the array ");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());

            int[] arrayOfNumbers = new int[sizeOfArray];
            Console.WriteLine("enter {0} elements", sizeOfArray);

            
            for (int i = 0; i < sizeOfArray; i++)
            {
                arrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            int largest = arrayOfNumbers[0];
            int smallest = arrayOfNumbers[0];

            for (int i = 0; i < sizeOfArray; i++)
            {
                if (arrayOfNumbers[i] > largest)
                {
                    largest = arrayOfNumbers[i];
                }

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