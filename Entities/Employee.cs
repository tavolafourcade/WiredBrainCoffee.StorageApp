namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Employee : EntityBase //Inherite from EntityBase
    {
        // Constructors
        public string? FirstName { get; set; } // ? it's used for non nullable specification

        public override string ToString() => $"Id: {Id}, FirstName: {FirstName}";

    }

    
}
