namespace Array_and_List_Q6
{
    internal class SumOfArray
    {
        static void Main()
        {
            //asking user to enter size of the array
            Console.WriteLine("Enter the size of the array ");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());

            int[] arrayOfNumbers = new int[sizeOfArray];
            Console.WriteLine("enter {0} elements", sizeOfArray);

            int sum = 0;
            //taking elements  from the user and also calculating sum of all the even number
            for (int i = 0; i < sizeOfArray; i++)
            {
                arrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
                if (arrayOfNumbers[i] %2 == 0)
                {
                    sum = sum + arrayOfNumbers[i];
                }
            }

            Console.WriteLine("Sum of All the Even number of the array is : {0}.", sum);
        }
    }
}