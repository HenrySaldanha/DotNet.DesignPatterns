namespace DesignPatterns.State;
internal abstract class State
{
    public abstract void Change(Lamp context);
}