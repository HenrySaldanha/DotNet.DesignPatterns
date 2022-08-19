namespace DesignPatterns.Builder;
internal class ConcreteBuilder : IBuilder
{
    private Message _message;

    public ConcreteBuilder() => 
        _message = new Message(Guid.NewGuid());

    private void Reset() => 
        _message = new Message(Guid.NewGuid());

    public ConcreteBuilder AddMessageText(string message)
    {
        _message.Text = message;
        return this;
    }

    public ConcreteBuilder AddRecipient(string recipient)
    {
        _message.Recipient = recipient;
        return this;
    }

    public ConcreteBuilder AddSender(string sender)
    {
        _message.Sender = sender;
        return this;
    }

    public ConcreteBuilder AddImageUrl(string url)
    {
        _message.ImageUrl = url;
        return this;
    }

    public Message Build()
    {
        var message = _message;
        Reset();
        return message;
    }
}
