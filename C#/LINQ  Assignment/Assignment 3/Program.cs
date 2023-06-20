namespace Assignment_3
{
    class FindTheString
    {
        static void Main()
        {
            Console.WriteLine("Enter list of strings (sperated with coma's)");
            string inputOfString = Console.ReadLine();

            string[] collectionOfString = inputOfString.Split(',');

            //linq query for finding the shortest string
            var shortestString = from i in collectionOfString
                                 orderby i.Length
                                 select i;

            //linq query for finding the longest string
            var longestString = from i in collectionOfString
                                orderby i.Length descending
                                select i;

            Console.WriteLine("-----\nShortest string is: {0}", shortestString.FirstOrDefault());
            Console.WriteLine("Longest string is : {0}", longestString.FirstOrDefault());
        }
    }
}