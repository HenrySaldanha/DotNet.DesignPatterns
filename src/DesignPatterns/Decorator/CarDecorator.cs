namespace DesignPatterns.Decorator;
internal class CarDecorator : ICar
{
    private readonly ICar _car;
    public CarDecorator(ICar car) => _car = car;
    public virtual string GetCar() => _car.GetCar();
}
