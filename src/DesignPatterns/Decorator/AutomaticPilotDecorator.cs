namespace DesignPatterns.Decorator;
internal class AutomaticPilotDecorator : CarDecorator
{
    public AutomaticPilotDecorator(ICar car): base(car){ }

    public override string GetCar()
    {
        var car = base.GetCar();
        return $"{car} with automatic pilot";
    }
}
