namespace DesignPatterns.Strategy;
internal class CalculateShippingPrice
{
    private CalculateShippingPriceStrategy strategy;
    public void SetCompany(CalculateShippingPriceStrategy sortstrategy) => strategy = sortstrategy;
    public int Calculate(string from, string to) => strategy.Calculate(from, to);
}
