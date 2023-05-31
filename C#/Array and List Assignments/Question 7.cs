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