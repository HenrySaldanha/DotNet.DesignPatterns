namespace DesignPatterns.State;
internal class Lamp
{
    public State State { get; set; }
    public Lamp(State state)
    {
        State = state;
        Console.WriteLine($"Initial State {state.GetType()}");
    }

    public void ChangeState()=>
        State.Change(this);
}