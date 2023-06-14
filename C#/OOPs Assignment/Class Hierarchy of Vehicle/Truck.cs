using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Assignment
{
    class Truck : Vehicle
    {
        public int Load { get; set; }
        public void GetTruckDetails()
        {
            Console.WriteLine("Enter your Truck details");
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

            Console.Write("Load: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(),out int temp) || temp > 1500 || temp < 3000)
                {
                    Load = temp;
                    break;
                }

                else
                {
                    Console.WriteLine("Plese enter valid number");
                }
            }
        }

        public void ShowTruckDetails()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Introducing the {Color} {Year} {Brand} {Model}, " +
                $"a robust and reliable truck equipped with a {Load} load capacity. " +
                "This truck is perfect for transporting heavy cargo and tackling challenging transportation tasks with ease.");
            Console.WriteLine("---------------------");
        }
    }
}
