namespace Array_and_List_Q2
{
    class StringCount
    {
        static void Main()
        {
            //asking user to enter array size
            Console.Write("Enter the size of the array : ");
            int input = Convert.ToInt32(Console.ReadLine());

            //creating array of string with the size of user given number
            string[] arrayOfString = new string[input];

            Console.WriteLine("Enter any {0} strings ", input);
            int totalNoOfStrings = 0;
            for (int i = 0; i < input; i++)
            {
                arrayOfString[i] = Console.ReadLine();
                //while taking input we are also storing length of string in variable
                totalNoOfStrings = totalNoOfStrings + arrayOfString[i].Length;
            }

            Console.WriteLine("Length of the array of string is {0} ", totalNoOfStrings);
        }
    }
}