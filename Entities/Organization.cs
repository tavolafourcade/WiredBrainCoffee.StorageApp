namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Organization : EntityBase
    {
        // Constructors
        
        public string? Name { get; set; } // ? it's used for non nullable specification

        public override string ToString() => $"Id: {Id}, Name: {Name}";

    }
}
