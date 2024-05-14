using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int? Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, int power, int? displacement = null, string efficiency = "n/a")
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public override string ToString()
        {
            return $"{Model}:\n    Power: {Power}\n    Displacement: {(Displacement.HasValue ? Displacement.ToString() : "n/a")}\n    Efficiency: {Efficiency}";
        }
    }
}
