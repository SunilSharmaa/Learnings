namespace Array_and_List_Q8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());

            int[] firstArray = new int[sizeOfArray];
            int[] secondArray = new int[sizeOfArray];

            Console.WriteLine("enter the {0} elements of first array", sizeOfArray);
            for (int i = 0; i < sizeOfArray; i++)
            {
                firstArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int count = 0;
            Console.WriteLine("enter the {0} elements of second array", sizeOfArray);
            for (int i = 0; i < sizeOfArray; i++)
            {
                secondArray[i] = Convert.ToInt32(Console.ReadLine());
                
            }

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