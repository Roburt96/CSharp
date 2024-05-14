using System.Drawing;
using System.Reflection;

namespace CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine, int? weight = null, string color = "n/a")
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public override string ToString()
        {
            return $"{Model}:\n  {Engine}\n  Weight: {(Weight.HasValue ? Weight.ToString() : "n/a")}\n  Color: {Color}";
        }
    }
}
