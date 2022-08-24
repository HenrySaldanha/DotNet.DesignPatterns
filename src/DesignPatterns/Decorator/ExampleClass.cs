namespace DesignPatterns.Decorator;
internal class ExampleClass
{
    protected void Method()
    {
        var car = new Car();
        var automaticPilotDecorator = new AutomaticPilotDecorator(car);
        var automaticTransmissionDecorator = new AutomaticTransmissionDecorator(automaticPilotDecorator);
        var sunroofDecorator = new SunroofDecorator(automaticTransmissionDecorator);

        Console.WriteLine(sunroofDecorator.GetCar());
    }
}