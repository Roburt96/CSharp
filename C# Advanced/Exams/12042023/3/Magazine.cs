using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; set; }

        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }

        public void AddCloth(Cloth cloth)
        {
            if(Clothes.Count < Capacity) 
            {
                Clothes.Add(cloth);
            }
        }

        public bool RemoveCloth(string color)
        {
            var check = Clothes.FirstOrDefault(x => x.Color == color);
            if(check != null)
            {
                Clothes.Remove(check);
                return true;
            }
            return false;
        }

        public Cloth GetSmallestCloth()
        {
            return Clothes.OrderBy(x => x.Size).FirstOrDefault();
        }

        public Cloth GetCloth(string color)
        {
            return Clothes.FirstOrDefault(c => c.Color == color);
        }

        public int GetClothCount()
        {
            return Clothes.Count;
        }

        public string Report()
        {
            StringBuilder reportBuilder = new StringBuilder();
            reportBuilder.AppendLine($"{Type} magazine contains:");

            foreach (var item in Clothes.OrderBy(x => x.Size))
            {
                reportBuilder.AppendLine(item.ToString());
            }

            return reportBuilder.ToString();
        }
    }
    
}
