namespace Array_and_List_Q4
{
    class ReverseOrderOfNames
    {
        static void Main()
        {
            string[] arrayOfNames = new string[5];
            Console.WriteLine("Enter any 5 names");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}. ", i + 1);
                arrayOfNames[i] = Console.ReadLine();
                
            }

            Console.WriteLine("\nAfter reversing the order");
            //logic for printing names in reverse order
            for (int i = 4; i >= 0; i--)
            {
                Console.Write("{0}. ", 5 - i);
                Console.WriteLine(arrayOfNames[i]);

            }

            
        }
    }
}