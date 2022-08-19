namespace DesignPatterns.Factory;
internal abstract class Dessert
{
    protected Dessert(string name, string description)
    {
        Name = name;
        Description = description;
    }
    public string Name { get; set; }
    public string Description { get; set; }
    public override string ToString() => $"{Name} {Description}";
}