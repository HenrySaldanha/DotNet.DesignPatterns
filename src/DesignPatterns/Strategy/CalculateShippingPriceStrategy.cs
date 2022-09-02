namespace DesignPatterns.Strategy;
internal abstract class CalculateShippingPriceStrategy
{
    public abstract int Calculate(string from, string to);
}
