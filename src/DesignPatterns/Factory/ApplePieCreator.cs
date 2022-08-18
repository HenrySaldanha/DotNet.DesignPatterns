namespace DesignPatterns.Factory;
internal class ApplePieCreator : Creator
{
    public override Dessert FactoryMethod(string name, string description) =>
        new ApplePie(name, description);

}