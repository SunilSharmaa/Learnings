namespace Array_and_List_Q5
{
    class FindTheNumber
    {
        static void Main()
        {
            //creating array of size 5 and initializing 
            int[] arrayOfNumbers = new int[5] {1, 2, 3, 4, 5}; 
            Console.Write("enter any number : ");

            //asking user to enter number for searching
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            //checking if the number is present in the array
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