namespace DesignPatterns.Decorator;
internal class AutomaticTransmissionDecorator : CarDecorator
{
    public AutomaticTransmissionDecorator(ICar car) : base(car){ }

    public override string GetCar()
    {
        var car = base.GetCar();
        return $"{car} with automatic transmission";
    }
}