namespace Array_and_List_Q2
{
    class StringCount
    {
        static void Main()
        {
            int input = 0;
            //checking for invalid input
            try
            {
                //asking user to enter array size
                Console.Write("Enter the size of the array : ");
                input = Convert.ToInt32(Console.ReadLine());

                //will throw error if the size is 0 or less then zero
                if (input == 0 || input < 0)
                {
                    throw new ArgumentException();
                }
            } 
            catch (FormatException)
            {
                Console.WriteLine("Invalid input: enter integer number only");
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("value cannot be zero or less then zero");
                return;
            }

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