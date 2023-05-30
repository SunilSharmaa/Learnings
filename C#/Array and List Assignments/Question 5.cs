namespace Array_and_List_Q5
{
    class FindTheNumber
    {
        static void Main()
        {
            int[] arrayOfNumbers = new int[5] {1, 2, 3, 4, 5}; 
            Console.Write("enter any number : ");

            int inputNumber = Convert.ToInt32(Console.ReadLine());

            bool found = arrayOfNumbers.Contains(inputNumber);

            if (found == true)
            {
                Console.WriteLine("Found");
            }

            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}