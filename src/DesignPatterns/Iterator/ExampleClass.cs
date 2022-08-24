namespace DesignPatterns.Iterator;
internal class ExampleClass
{
    protected void Method()
    {
        var collection = new MyCollection<string>();
        collection.AddItem("One");
        collection.AddItem("Two");
        collection.AddItem("Three");

        foreach (var element in collection)
            Console.WriteLine(element);

        collection.ReverseDirection();

        foreach (var element in collection)
            Console.WriteLine(element);
    }
}
