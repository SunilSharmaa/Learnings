using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Assignment
{
    class Car : Vehicle
    {
        public int NumbersOfSeater { get; set; }

        public void GetCarDetails ()
        {
            Console.WriteLine("Enter your car details");
            Console.Write("Brand: ");
            Brand = Console.ReadLine();

            Console.Write("Model: ");
            Model = Console.ReadLine();

            Console.Write("Color: ");
            Color = Console.ReadLine();

            while (true)
            {
                Console.Write("Year: ");
                if (int.TryParse(Console.ReadLine(), out int temp))
                {
                    Year = temp;
                    break;
                }

                else
                {
                    Console.WriteLine("Please enter valid year");
                }
            }

            Console.Write("Number of Seater: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int temp) || temp == 2 || temp == 4 || temp == 5 || temp == 7) 
                {
                    NumbersOfSeater = temp;
                    break;
                }

                else
                {
                    Console.WriteLine("Please enter correct number (2,4,5,7)");
                }
            }
        }

        public void ShowCarDetails ()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Introducing the {Color} {Year} {Brand} {Model}, " +
                $"a stylish and reliable vehicle with {NumbersOfSeater} seating capacity. " +
                "This car is perfect for those seeking both comfort and performance on the road.");
            Console.WriteLine("---------------------");
        }
    }
}
