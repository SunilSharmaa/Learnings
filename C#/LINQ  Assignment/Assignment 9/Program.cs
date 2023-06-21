namespace Assignment_9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter List of string (separate with coma)");
            string listOfString = Console.ReadLine();

            if (string.IsNullOrEmpty(listOfString))
            {
                Console.WriteLine("Input cannot be empty or null");
                return;
            }

            else { }
            string[] arrayOfString = listOfString.Split(',');

            //linq query
            var stringStartWithA = from i in arrayOfString
                                   where i.StartsWith("A")
                                   select i;

            Console.WriteLine("--------------\nList of string that starts with character 'A' ");
            foreach ( var i in stringStartWithA )
            {
                Console.WriteLine(i);
            }


        }
    }
}