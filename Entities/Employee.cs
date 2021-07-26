namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Employee
    {
        // Constructors
        public int Id { get; set; }
        public string? FirstName { get; set; } // ? it's used for non nullable specification

        public override string ToString() => $"Id: {Id}, FirstName: {FirstName}";

    }
}
