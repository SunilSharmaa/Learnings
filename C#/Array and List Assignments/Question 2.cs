namespace Array_and_List_Q2
{
    class StringCount
    {
        static void Main()
        {
            Console.Write("Enter the size of the array : ");
            int input = Convert.ToInt32(Console.ReadLine());

            string[] arrayOfString = new string[input];

            Console.WriteLine("Enter any {0} strings ", input);
            int totalNoOfStrings = 0;
            for (int i = 0; i < input; i++)
            {
                arrayOfString[i] = Console.ReadLine();
                totalNoOfStrings = totalNoOfStrings + arrayOfString[i].Length;
            }

            Console.WriteLine("Length of the array of string is {0} ", totalNoOfStrings);
        }
    }
}