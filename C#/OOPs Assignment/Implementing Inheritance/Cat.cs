using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Inheritance
{
    class Cat : Animal
    {
        public string FurColor { get; set; }

        public void GetCatDetails()
        {
            Console.WriteLine("-------------- \nEnter following details of a Cat");

            Console.Write("Fur Color: ");
            string temp = Console.ReadLine();
            if (string.IsNullOrEmpty(temp))
            {
                Console.WriteLine("cannot be null or empty");
                return;
            }
            else
            {
                FurColor = temp;
            }


            Console.Write("Name: ");
            temp = Console.ReadLine();
            if (string.IsNullOrEmpty(temp))
            {
                Console.WriteLine("cannot be null or empty");
                return;
            }
            else
            {
                Name = temp;
            }

            Console.Write("Age: ");
            if (int.TryParse(Console.ReadLine(), out int tempAge) && tempAge > 0)
            {
                Age = tempAge;
            }
            else
            {
                Console.WriteLine("Please enter valid number");
                return;
            }

        }

        public override void AnimalSound()
        {
            Console.WriteLine($"\nI have a cat with {FurColor} fur who is {Age} years old. It makes the sound 'Meow!'.");
            Console.WriteLine("------------");
        }
    }
}
