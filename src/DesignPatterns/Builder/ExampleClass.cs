namespace DesignPatterns.Builder;
internal class ExampleClass
{
    protected void Method()
    {
        var director = new Director();
        var messageI = director.BuildSimpleMessage("batman", "robin", "Make your fears afraid of you.");
        var messageII = director.BuildMessageWithImage("joker", "batman", "What do you think I look like? Clown?\r\nLook at you, all dressed in black!", "http://aaaaa");

        Console.WriteLine(messageI.ToString());
        Console.WriteLine(messageII.ToString());
    }
}