namespace DesignPatterns.Strategy;
internal class CompanyB : CalculateShippingPriceStrategy
{
    public override int Calculate(string from, string to)
    {
        var price = 234;
        Console.WriteLine($"Company B {from} -> {to} ${price}");
        return price;
    }
}
