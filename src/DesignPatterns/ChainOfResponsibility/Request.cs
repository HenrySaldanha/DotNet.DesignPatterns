namespace DesignPatterns.ChainOfResponsibility;
internal class Request
{
    public List<string> Headers { get; set; }
    public string UrlParams { get; set; }
    public string Body { get; set; }
}
