namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double DistanceTraveled { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            DistanceTraveled = 0;
        }

        public bool CanMove(double distance)
        {
            double neededFuel = distance * FuelConsumptionPerKilometer;
            return neededFuel <= FuelAmount;
        }

        public void Drive(double distance)
        {
            double neededFuel = distance * FuelConsumptionPerKilometer;
            FuelAmount -= neededFuel;
            DistanceTraveled += distance;
        }
    }
}