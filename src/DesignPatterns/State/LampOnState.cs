namespace DesignPatterns.State;
internal class LampOnState : State
{
    public override void Change(Lamp context)
    {
        context.State = new LampOffState();
        Console.WriteLine("Turned off the light. State changed.");
    }
}