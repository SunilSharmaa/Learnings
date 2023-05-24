namespace Assessment_4
{
    class FibonacciSeries
    {
        static void Main()
        {
            //declaring a variable to store user input
            int inputnumber;
            Console.WriteLine("enter any integer number: ");
            inputnumber = Convert.ToInt32(Console.ReadLine());

            //variables to create fibonacci series
            int start=0, next=1, total;

            Console.WriteLine("Fibonacci series are")

            //defined logic to calculate series
            for (int i = 0; i < inputnumber; i++)
            {
                Console.WriteLine(start);
                total = start + next;
                start = next;
                next = total;

            }
        }
    }
}