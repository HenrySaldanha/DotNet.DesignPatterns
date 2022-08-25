namespace DesignPatterns.ChainOfResponsibility;
internal class ExampleClass
{
    protected void Method()
    {
        var headerHandler = new HeaderHandler();
        var urlParamsHandler = new UrlParamsHandler();
        var bodyHandler = new BodyHandler();

        headerHandler.AddHandler(urlParamsHandler).AddHandler(bodyHandler);

        Console.WriteLine("Complete request:\n");
        var request = new Request
        {
            Body = "body",
            UrlParams = "value=newValue",
            Headers = new List<string> { "application:newapp" }
        };

        headerHandler.Handle(request);

        Console.WriteLine("\nRequest with body:\n");
        request = new Request
        {
            Body = "body"
        };

        headerHandler.Handle(request);
    }
}