using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar sportCar = new SportCar(300, 20.2);
            sportCar.Drive(5);

            RaceMotorcycle raceMoto = new RaceMotorcycle(150, 10.5);
            raceMoto.Drive(4);
        }
    }
}
