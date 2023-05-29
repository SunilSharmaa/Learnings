namespace Assessment_3
{
    class PrimeNumber
    {
        static void Main()
        {
            int inputNumber;
            int count = 0;

            Console.Write("Enter a positive integer no: ");
            inputNumber = Convert.ToInt32(Console.ReadLine());

            //defing the logic
            for (int i = 2; i <= Math.Sqrt(inputNumber); i++)
            {
                if(inputNumber % i == 0)
                {
                    count++;
                    break;
                }
            }

            //checking if the count value is 2 or more than  2
            if (count == 0)
            {
                Console.WriteLine("{0} is Prime number", inputNumber);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime number", inputNumber);
            }

        }
    }
}