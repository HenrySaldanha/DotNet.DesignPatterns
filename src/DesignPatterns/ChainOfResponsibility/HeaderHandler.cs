namespace DesignPatterns.ChainOfResponsibility;
internal class HeaderHandler : AbstractHandler
{
    public override Request Handle(Request request)
    {
        if (request.Headers is not null && request.Headers.Any())
            Console.WriteLine("request headers have been processed");

        return base.Handle(request);
    }
}