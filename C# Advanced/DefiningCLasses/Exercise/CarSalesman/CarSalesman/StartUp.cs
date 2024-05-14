using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            int engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                string[] engineInfo = Console.ReadLine().Split();
                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                int? displacement = null;
                string efficiency = "n/a";
                if (engineInfo.Length > 2)
                {
                    if (int.TryParse(engineInfo[2], out int disp))
                    {
                        displacement = disp;
                        if (engineInfo.Length > 3)
                        {
                            efficiency = engineInfo[3];
                        }
                    }
                    else
                    {
                        efficiency = engineInfo[2];
                    }
                }
                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(model, engine);
            }

            int carCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < carCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];
                Engine engine = engines[carInfo[1]];
                int? weight = null;
                string color = "n/a";
                if (carInfo.Length > 2)
                {
                    if (int.TryParse(carInfo[2], out int w))
                    {
                        weight = w;
                        if (carInfo.Length > 3)
                        {
                            color = carInfo[3];
                        }
                    }
                    else
                    {
                        color = carInfo[2];
                    }
                }
                Car car = new Car(model, engine, weight, color);
                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
