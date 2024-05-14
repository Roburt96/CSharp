using System.Globalization;

namespace SpeedRacing
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKilometer = double.Parse(carInfo[2], CultureInfo.InvariantCulture);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(model, car);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split();
                string carModel = tokens[1];
                double amountOfKm = double.Parse(tokens[2]);

                if (cars.ContainsKey(carModel))
                {
                    Car car = cars[carModel];
                    if (car.CanMove(amountOfKm))
                    {
                        car.Drive(amountOfKm);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }

            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
            }
        }
    }
}
