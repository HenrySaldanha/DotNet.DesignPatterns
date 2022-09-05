namespace DesignPatterns.State;
internal class LampOffState : State
{
    public override void Change(Lamp context)
    {
        context.State = new LampOnState();
        Console.WriteLine("Turned on the light. State changed.");
    }
}