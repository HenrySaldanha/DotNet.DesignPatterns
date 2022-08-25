namespace DesignPatterns.ChainOfResponsibility;
internal class UrlParamsHandler : AbstractHandler
{
    public override Request Handle(Request request)
    {
        if (request.UrlParams != null)
            Console.WriteLine("request url params have been processed");

        return base.Handle(request);
    }
}