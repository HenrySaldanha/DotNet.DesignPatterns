namespace DesignPatterns.ChainOfResponsibility;
internal interface IHandler
{
    IHandler AddHandler(IHandler handler);

    Request Handle(Request request);
}