namespace DesignPatterns.Strategy;
internal class CompanyA : CalculateShippingPriceStrategy
{
    public override int Calculate(string from, string to)
    {
        var price = 123;
        Console.WriteLine($"Company A {from} -> {to} ${price}");
        return price;
    }
}
