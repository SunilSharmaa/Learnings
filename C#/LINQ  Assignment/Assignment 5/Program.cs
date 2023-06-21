namespace Assignment_5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int size = 0;

            if (int.TryParse(Console.ReadLine(), out int temp) && temp > 0)
            {
                size = temp;
            }

            else
            {
                Console.WriteLine("Inavlid input, please enter valid integer number");
                return;
            }

            int[] arrayOfInteger = new int[size];

            Console.WriteLine("Enter {0} elemets of array", size);

            for (int i = 0; i < size; i++)
            {
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    arrayOfInteger[i] = temp;
                }

                else
                {
                    Console.WriteLine("Invalid input, Please enter valid integer number");
                    return;
                }
            }

            //linq query to

            var numbersDivisibleBy3 = from i in arrayOfInteger
                                      where i % 3 == 0
                                      select i;

            var average = numbersDivisibleBy3.Average();

            Console.WriteLine("Average of all the number divisible by 3: {0}", average);
        }
    }
}