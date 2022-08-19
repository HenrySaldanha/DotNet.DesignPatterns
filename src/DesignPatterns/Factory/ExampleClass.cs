namespace DesignPatterns.Factory;
internal class ExampleClass
{
    protected void Method()
    {
        var applePieCreator = new ApplePieCreator();
        var iceCreamCreator = new IceCreamCreator();
        var iceCream = iceCreamCreator.FactoryMethod("Ice Cream Chocolate", "lactose free");
        var applePie = applePieCreator.FactoryMethod("Apple Pie", "Without gluten");

        Console.WriteLine("Created {0} {1}", iceCream.GetType().Name, iceCream.ToString());
        Console.WriteLine("Created {0} {1}", applePie.GetType().Name, applePie.ToString());
    }
}
