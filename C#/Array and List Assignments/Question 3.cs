namespace Array_and_List_Q3
{
    class CalculateAverage
    {
        static void Main()
        {
            int[] arrayOfNumbers = new int[5];
            Console.WriteLine("Enter 5 elements of array");

            float total = 0.0f;
            for (int i = 0; i < 5; i++)
            {
                arrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
                total = total + arrayOfNumbers[i];
            }

            float average = total / 5;
            Console.WriteLine("Average of these no. is {0:F2}", average);
        }
    }
}