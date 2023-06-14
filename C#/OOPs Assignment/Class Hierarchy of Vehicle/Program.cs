namespace OOPs_Assignment
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                // Get the type of vehicle from the user
                Console.WriteLine("What type of vehicle would you like to create?");
                Console.WriteLine("1. Car \n2. Bike \n3. Truck \n4. Exit");

                int vehicleType = 0;

                if (int.TryParse(Console.ReadLine(), out int temp) && temp > 0 && temp < 5)
                {
                    vehicleType = temp;
                }
                else
                {
                    Console.WriteLine("Enter valid input");
                }

                // Create a new vehicle of the specified type

                switch (vehicleType)
                {
                    case 1:
                        Car car = new Car();
                        car.GetCarDetails();
                        car.ShowCarDetails();
                        break;
                    case 2:
                        Bike bike = new Bike();
                        bike.GetBikeDetails();
                        bike.ShowBikeDetails();
                        break;
                    case 3:
                        Truck truck = new Truck();
                        truck.GetTruckDetails();
                        truck.ShowTruckDetails();
                        break;
                    case 4:
                        Console.WriteLine("Exiting....");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please enter (1-4)");
                        break;
                }

            }
        }
    }
}