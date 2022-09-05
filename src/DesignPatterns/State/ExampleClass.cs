namespace DesignPatterns.State;

internal class ExampleClass
{
    protected void Method()
    {
        var context = new Lamp(new LampOnState());
        context.ChangeState();
        context.ChangeState();
        context.ChangeState();
    }
}
