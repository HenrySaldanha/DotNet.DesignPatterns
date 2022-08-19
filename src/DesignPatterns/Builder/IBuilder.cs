namespace DesignPatterns.Builder;
internal interface IBuilder
{
    ConcreteBuilder AddImageUrl(string url);
    ConcreteBuilder AddMessageText(string message);
    ConcreteBuilder AddRecipient(string recipient);
    ConcreteBuilder AddSender(string sender);
    Message Build();
}