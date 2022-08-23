namespace DesignPatterns.ServiceLocator;

internal class ServiceLocator : IServiceLocator
{
    private readonly IDictionary<object, object> _services;

    internal ServiceLocator()
    {
        _services = new Dictionary<object, object>
        {
            { typeof(IUserService), new UserService() },
            { typeof(ICompanyService), new CompanyService() }
        };
    }

    public T TryGetService<T>()
    {
        try
        {
            return (T)_services[typeof(T)];
        }
        catch (KeyNotFoundException)
        {
            throw new ApplicationException($"The service {nameof(T)} is not found");
        }
    }
}
