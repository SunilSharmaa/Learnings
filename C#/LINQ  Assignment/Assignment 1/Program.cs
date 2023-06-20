using System.Linq;

namespace Assignment_1
{
    class SumOfAllEvenNumber
    {
        static void Main()
        {
            int sizeOfArray = 0;

            Console.Write("Enter the size of the array: ");
            
            if (int.TryParse(Console.ReadLine(), out int temp)) 
            { 
                sizeOfArray = temp;
            }

            else
            {
                Console.WriteLine("Please enter valid integer number.");
                return;
            }

            //creating the array of size user input
            int[] arrayOfNumbers = new int[sizeOfArray];

            //taking elements in the array
            Console.WriteLine("Enter {0} elements of array: ", sizeOfArray);
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int temp2))
                {
                    arrayOfNumbers[i] = temp2;
                }
                else
                {
                    Console.WriteLine("Please enter valid integer number");
                    return;
                }
            }

            // finding all even number using linq query
            var linqQueryData = from i in arrayOfNumbers
                                where i % 2 == 0
                                select i;

            //calculating sum of all the even numbers
            int sum = linqQueryData.Sum();

            Console.WriteLine("Sum of all the even number is: {0}", sum);

        }
    }
}