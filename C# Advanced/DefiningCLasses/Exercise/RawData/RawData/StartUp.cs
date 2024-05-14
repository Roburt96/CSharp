using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double[] tirePressures = { double.Parse(carInfo[5], CultureInfo.InvariantCulture), double.Parse(carInfo[7],  CultureInfo.InvariantCulture),
                                       double.Parse(carInfo[9],  CultureInfo.InvariantCulture), double.Parse(carInfo[11], CultureInfo.InvariantCulture) };
                int[] tireAges = { int.Parse(carInfo[6]), int.Parse(carInfo[8]),
                               int.Parse(carInfo[10]), int.Parse(carInfo[12]) };

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tirePressures, tireAges);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1)))
                {
                    Console.WriteLine(car);
                }
            }
            else if (command == "flammable")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250))
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
