using DotNet.DesignPatterns.ServiceLocator;

namespace DesignPatterns.Factory;
internal class ExampleClass
{
    protected void Method()
    {
        var serviceLocator = new ServiceLocator();

        var userService = serviceLocator.TryGetService<IUserService>();
        var companyService = serviceLocator.TryGetService<ICompanyService>();

        Console.WriteLine(userService.GetUserName(Guid.Empty));
        Console.WriteLine(companyService.GetCompanyName(Guid.Empty));
    }
}
