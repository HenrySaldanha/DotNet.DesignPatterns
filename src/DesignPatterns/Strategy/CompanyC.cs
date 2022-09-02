namespace DesignPatterns.Strategy;
internal class CompanyC : CalculateShippingPriceStrategy
{
    public override int Calculate(string from, string to)
    {
        var price = 3445;
        Console.WriteLine($"Company C {from} -> {to} ${price}");
        return price;
    }
}