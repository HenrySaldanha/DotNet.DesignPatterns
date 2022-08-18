namespace DesignPatterns.Factory;
internal abstract class Creator
{
    public abstract Dessert FactoryMethod(string name, string description);
}
