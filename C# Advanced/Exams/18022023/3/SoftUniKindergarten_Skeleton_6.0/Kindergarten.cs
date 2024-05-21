using System.Collections.Generic;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Child> Registry { get; set; }

        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public bool AddChild(Child child)
        {
            if (Registry.Count < Capacity)
            {
                Registry.Add(child);
                return true;
            }
            return false;
        }
        public bool RemoveChild(string childFullName)
        {
            var names = childFullName.Split();
            Child childToRemove = Registry.Find(c => c.FirstName == names[0] && c.LastName == names[1]);
            if (childToRemove != null)
            {
                Registry.Remove(childToRemove);
                return true;
            }
            return false;
        }

        public Child GetChild(string chieldFullName)
        {
            var names = chieldFullName.Split();
            return Registry.Find(c => c.FirstName == names[0] && c.LastName == names[1]);
        }
        public int ChildrenCount()
        {
            return Registry.Count;
        }
        public string RegistryReport()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine($"Registered children in {Name}:");
            foreach (var child in Registry)
            {
                sb.AppendLine(child.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }

}
