namespace DesignPatterns.ChainOfResponsibility;
internal class BodyHandler : AbstractHandler
{
    public override Request Handle(Request request)
    {
        if (request.Body != null)
            Console.WriteLine("request body have been processed");

        return base.Handle(request);
    }
}