namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Organization
    {
        // Constructors
        public int Id { get; set; }
        public string? Name { get; set; } // ? it's used for non nullable specification

        public override string ToString() => $"Id: {Id}, Name: {Name}";

    }
}
