namespace DesignPatterns.Decorator;
internal class SunroofDecorator : CarDecorator
{
    public SunroofDecorator(ICar car) : base(car) { }
    public override string GetCar()
    {
        var car = base.GetCar();
        return $"{car} with sunroof";
    }
}