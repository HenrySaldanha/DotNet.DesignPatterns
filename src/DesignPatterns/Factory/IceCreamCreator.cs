namespace DesignPatterns.Factory;
internal class IceCreamCreator : Creator
{
    public override Dessert FactoryMethod(string name, string description) =>
        new IceCream(name, description);
}