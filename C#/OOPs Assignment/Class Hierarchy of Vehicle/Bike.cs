using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Assignment
{
    class Bike : Vehicle
    {
        public string Engine { get; set; }
        public void GetBikeDetails()
        {
            Console.WriteLine("Enter your Bike details");
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

            Console.Write("Engine: ");
            Engine = Console.ReadLine();
        }

        public void ShowBikeDetails()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Introducing the {Color} {Year} {Brand} {Model}, " +
                $"a sleek and powerful bike equipped with a {Engine} engine. " +
                "This bike is perfect for riders who crave exhilarating speed and performance on the road.");
            Console.WriteLine("---------------------");
        }
    }
}
