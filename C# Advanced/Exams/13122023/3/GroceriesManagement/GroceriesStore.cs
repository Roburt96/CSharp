using System.Text;

namespace GroceriesManagement
{
    public class GroceriesStore
    {
        public int Capacity { get; set; }
        public double Turnover { get; set; }
        public List<Product> Stall {  get; set; }
        public double Total { get; set; }

        public GroceriesStore(int capacity)
        {
            Capacity = capacity;
            Turnover = 0;
            Stall = new List<Product>();
            Total = 0;
        }

        public void AddProduct(Product product)
        {
            if (Stall.Count >= Capacity)
            {
                return;
            }
            if(Stall.Any(x => x.Name == product.Name))
            {
                return;
            }
            Stall.Add(product);
        }
        public bool RemoveProduct(string name)
        {
            var product = Stall.FirstOrDefault(x => x.Name == name);
            if (product != null)
            {
                Stall.Remove(product);
                return true;
            }
            return false;
        }

        public string SellProduct(string name, double quantity)
        {
            var product = Stall.FirstOrDefault(x=>x.Name == name);
            if (product != null)
            {
                Turnover = product.Price * quantity;
                Total += Turnover;
                return $"{product.Name} - {Turnover:F2}$";
            }
            return "Product not found";
        }

        public string GetMostExpensive()
        {
            var product = Stall.OrderByDescending(x => x.Price).FirstOrDefault();
            return product.ToString();
        }
        
        public string CashReport()
        {
            return $"Total Turnover: {Total:F2}$";
        }

        public string PriceList()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Groceries Price List:");
            foreach (var item in Stall)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
