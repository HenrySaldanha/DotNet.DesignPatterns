namespace DesignPatterns.Prototype;
internal abstract class Prototype<T>
{
    public readonly Guid Id;
    public Prototype()
    {
        Id = Guid.NewGuid();
    }
    public abstract T Clone();
}
