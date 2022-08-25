namespace DesignPatterns.ChainOfResponsibility;
internal abstract class AbstractHandler : IHandler
{
    private IHandler _nextHandler;

    public IHandler AddHandler(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual Request Handle(Request request) => 
        _nextHandler is not null ? _nextHandler.Handle(request) : null;
}