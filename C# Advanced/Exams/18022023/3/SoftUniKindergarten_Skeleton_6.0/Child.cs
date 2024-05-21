namespace SoftUniKindergarten
{
    public class Child
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string ParantName {  get; set; }
        public string ContractNumber { get; set; }

        public Child(string firstName, string lastName, int age, string parentName, string contractNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ParantName = parentName;
            ContractNumber = contractNumber;
            
        }

        public override string ToString()
        {
            return $"Child: {FirstName} {LastName}, Age: {Age}, Contact info: {ParantName} - {ContractNumber}";
        }
    }
}
