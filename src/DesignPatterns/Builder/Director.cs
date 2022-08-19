namespace DesignPatterns.Builder;
internal class Director
{
    private IBuilder _builder;

    public Director() => 
        _builder = new ConcreteBuilder();

    public Message BuildSimpleMessage(string sender, string recipient, string text)
    {
        return _builder
            .AddRecipient(recipient)
            .AddSender(sender)
            .AddMessageText(text)
            .Build();
    }

    public Message BuildMessageWithImage(string sender, string recipient, string text, string url)
    {
        return _builder
            .AddRecipient(recipient)
            .AddSender(sender)
            .AddMessageText(text)
            .AddImageUrl(url)
            .Build();
    }
}