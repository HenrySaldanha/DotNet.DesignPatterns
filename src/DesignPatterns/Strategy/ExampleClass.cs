namespace DesignPatterns.Strategy;

internal class ExampleClass
{
    protected void Method()
    {
        var from = "Bangkok";
        var to = "Geneva";
        CalculateShippingPrice calculator = new CalculateShippingPrice();
        calculator.SetCompany(new CompanyA());
        calculator.Calculate(from, to);
        calculator.SetCompany(new CompanyB());
        calculator.Calculate(from, to);
        calculator.SetCompany(new CompanyC());
        calculator.Calculate(from, to);
        Console.ReadKey();
    }
}



