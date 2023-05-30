namespace Array_and_List_Q1
{
    class ArrayInitialize
    {
        static void Main()
        {
            //creating array and initializing
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            //displaying each array elements
            Console.WriteLine("Elements of array");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}