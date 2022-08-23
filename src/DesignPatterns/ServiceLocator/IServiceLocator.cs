namespace DesignPatterns.ServiceLocator;

internal interface IServiceLocator
{
    T TryGetService<T>();
}