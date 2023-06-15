using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Inheritance
{
    class Bird : Animal
    {
        public string FeatherColor { get; set; }

        public void GetBirdDetails()
        {
            Console.WriteLine("-------------- \nEnter following details of a Bird");

            Console.Write("Feather Color: ");
            string temp = Console.ReadLine();
            if (string.IsNullOrEmpty(temp))
            {
                Console.WriteLine("cannot be null or empty");
                return;
            }
            else
            {
                FeatherColor = temp;
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
            Console.WriteLine($"\nI have a bird with beautiful {FeatherColor} feathers who is {Age} years old. It makes the sound 'Chirp chirp!'");
            Console.WriteLine("------------");
        }
    }
}
