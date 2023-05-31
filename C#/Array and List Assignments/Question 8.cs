namespace Array_and_List_Q8
{
    class Program
    {
        static void Main()
        {
            //asking for the size of the array then we will create 2 arrays of same size
            Console.Write("Enter the size of the array: ");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());

            int[] firstArray = new int[sizeOfArray];
            int[] secondArray = new int[sizeOfArray];

            //taking elements of first array
            Console.WriteLine("enter the {0} elements of first array", sizeOfArray);
            for (int i = 0; i < sizeOfArray; i++)
            {
                firstArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            //taking elements of 2nd array
            Console.WriteLine("enter the {0} elements of second array", sizeOfArray);
            for (int i = 0; i < sizeOfArray; i++)
            {
                secondArray[i] = Convert.ToInt32(Console.ReadLine());
                
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