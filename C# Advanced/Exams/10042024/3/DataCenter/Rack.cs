using System.Text;

namespace DataCenter
{
    public class Rack
    {
        public int Slots { get; set; }
        public List<Server> Servers { get; set; }
        public int GetCount { get { return Servers.Count; } }

        public Rack(int slots)
        {
            Slots = slots;
            Servers = new List<Server>();
        }
        public void AddServer(Server server)
        {
            var currServer = Servers.FirstOrDefault(x => x.SerialNumber == server.SerialNumber);
            if (currServer == null)
            {
                if (Servers.Count < Slots)
                {
                    Servers.Add(server);
                }
            }
        }
        
        public bool RemoveServer(string serialnumber)
        {
            var server = Servers.FirstOrDefault(y => y.SerialNumber == serialnumber);
            if (server != null)
            {
                Servers.Remove(server);
                return true;
            }
            return false;
        }

        public string GetHighestPowerUsage()
        {
            var highestPowerServer = Servers.OrderByDescending(x => x.PowerUsage).FirstOrDefault();
            return highestPowerServer != null ? highestPowerServer.ToString() : "No servers available";
        }

        public int GetTotalCapacity()
        {
            return Servers.Sum(x => x.Capacity);
        }

        public string DeviceManager()
        {
            var serverList = Servers.Select(x => x.ToString()).ToList();
            return $"{Servers.Count} servers operating:\n{string.Join("\n", serverList)}";
        }
    }
}
