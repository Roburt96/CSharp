using System.Text;

namespace EstateAgency
{
    public class EstateAgency
    {
        public int Capacity { get; set; }
        public List<RealEstate> RealEstates { get; set; }
        public int Count => RealEstates.Count;

        public EstateAgency(int capacity)
        {
            Capacity = capacity;
            RealEstates = new List<RealEstate>();
        }

        public void AddRealEstate(RealEstate realEstate)
        {
            if (Count < Capacity && !RealEstates.Any(x => x.Address == realEstate.Address))
            {
                RealEstates.Add(realEstate);
            }
        }

        public bool RemoveRealEstate(string address)
        {
            var realEstate = RealEstates.FirstOrDefault(x => x.Address == address);
            if (realEstate != null)
            {
                RealEstates.Remove(realEstate);
                return true;
            }
            return false;
        }

        public List<RealEstate> GetRealEstates(string postalCode)
        {
            return RealEstates.FindAll(x => x.PostalCode == postalCode);
        }

        public RealEstate GetCheapest()
        {
            return RealEstates.OrderBy(x => x.Price).FirstOrDefault();
        }

        public double GetLargest()
        {
            var firstOrDefault = RealEstates.OrderByDescending(x => x.Size).FirstOrDefault();
            return firstOrDefault != null ? firstOrDefault.Size : 0;

        }

        public string EstateReport()
        {
            return string.Format("Real estates available:\n{0}", string.Join("\n", RealEstates));
        }
    }
}
