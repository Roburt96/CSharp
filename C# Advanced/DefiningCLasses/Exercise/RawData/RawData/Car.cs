namespace RawData
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,
                   double[] tirePressures, int[] tireAges)
        {
            Model = model;
            Engine = new Engine { Speed = engineSpeed, Power = enginePower };
            Cargo = new Cargo { Weight = cargoWeight, Type = cargoType };
            Tires = new List<Tire>();

            for (int i = 0; i < 4; i++)
            {
                Tires.Add(new Tire { Pressure = tirePressures[i], Age = tireAges[i] });
            }
        }

        public override string ToString()
        {
            return Model;
        }
    }

    class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
    }

    class Cargo
    {
        public int Weight { get; set; }
        public string Type { get; set; }
    }

    class Tire
    {
        public double Pressure { get; set; }
        public int Age { get; set; }
    }
}
