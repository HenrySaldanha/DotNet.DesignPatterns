namespace DesignPatterns.Factory;
internal abstract class Dessert
{
    public string Name { get; set; }
    public string Description { get; set; }
    protected Dessert(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public override string ToString() => $"{Name} {Description}";
}